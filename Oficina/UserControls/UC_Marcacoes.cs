using Biblioteca;
using Oficina.Forms;
using System.Net;
using System.Net.Mail;

namespace Oficina.UserControls
{
    public partial class UC_Marcacoes : UserControl
    {
        #region Propriedades

        public List<Marcacao> Marcacoes { get; set; } // lista de todas as marcações
        List<Cliente> Clientes; // lista de todos os clientes
        List<Servico> Servicos; // lista de todos os serviços
        List<Fatura> Faturas; // lista de todas as faturas

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do User Control UC_Marcacoes e inicializar a lista de marcações.
        /// </summary>
        /// <param name="marcacoes">A lista de marcações existentes.</param>
        /// <param name="clientes">A lista de clientes existentes.</param>
        /// <param name="servicos">A lista de serviços existentes.</param>
        /// <param name="faturas">A lista de faturas existentes.</param>
        public UC_Marcacoes(List<Marcacao> marcacoes, List<Cliente> clientes, List<Servico> servicos, List<Fatura> faturas)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Marcacoes = marcacoes ?? new List<Marcacao>(); // se marcacoes for null, uma nova lista de Marcacao será criada e atribuída a Marcacoes, evitando assim a excepção
            Clientes = clientes;
            Servicos = servicos;
            Faturas = faturas;

            InitializeComponent();

            // Inicializar a lista de marcações
            InitLista();
        }

        // Método para inicializar a lista de marcações
        public void InitLista()
        {
            // Limpar o interface e permitir atualizar a lista
            listBoxMarcacoes.DataSource = null;

            // Ordenar a lista de marcações por data e hora usando o LINQ
            List<Marcacao> marcacoesOrdenadas = Marcacoes.OrderBy(m => m.Data).ToList();

            // Atribuir a lista ordenada de marcações ao DataSource do listBox
            listBoxMarcacoes.DataSource = marcacoesOrdenadas;
        }

        // Evento que ocorre quando o item selecionado no listBox muda
        private void listBoxMarcacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se uma marcação está selecionada
            if (listBoxMarcacoes.SelectedItem is Marcacao marcacaoSelecionada)
            {
                // Atualizar as labels com os dados da marcação
                lblCliente.Text = marcacaoSelecionada.Cliente.NomeCompleto;
                lblVeiculo.Text = marcacaoSelecionada.Veiculo.MarcaModelo;

                // Atualizar a label da data com a data e a hora no formato desejado
                lblData.Text = marcacaoSelecionada.Data.ToString("dd/MM/yyyy HH:mm");

                // Atualizar a listBox de serviços com os serviços da marcação por ordem alfabética usando o LINQ
                List<Servico> servicosOrdenados = marcacaoSelecionada.Servicos.OrderBy(s => s.Descricao).ToList();

                listBoxServicos.DataSource = servicosOrdenados;
                listBoxServicos.DisplayMember = "Descricao";
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do formulário CriarMarcacao
            CriarMarcacao criarMarcacao = new CriarMarcacao(Marcacoes, Clientes, Servicos);

            // Exibir o formulário
            criarMarcacao.ShowDialog();

            // Atualizar a lista de marcações
            Marcacoes = criarMarcacao.Marcacoes;
            InitLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obter a marcação selecionada no listBox
            Marcacao marcacaoAEditar = (Marcacao)listBoxMarcacoes.SelectedItem;

            // Verificar se uma marcação foi selecionada
            if (marcacaoAEditar == null)
            {
                MessageBox.Show("Por favor, selecione uma marcação para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verificar se a marcação já foi faturada usando o LINQ
            if (Faturas.Any(f => f.Marcacao.Id == marcacaoAEditar.Id))
            {
                MessageBox.Show("Não é possível editar uma marcação que já foi faturada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Criar uma nova instância do formulário EditarMarcacao
            EditarMarcacao editarMarcacao = new EditarMarcacao(marcacaoAEditar, Clientes, Servicos, Marcacoes);

            // Exibir o formulário
            editarMarcacao.ShowDialog();

            // Actualizar a lista de marcações
            InitLista();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obter a marcação selecionada no listBox
            Marcacao marcacaoAEliminar = (Marcacao)listBoxMarcacoes.SelectedItem;

            // Verificar se uma marcação foi selecionada
            if (marcacaoAEliminar == null)
            {
                MessageBox.Show("Por favor, selecione uma marcação para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verificar se a marcação já foi faturada usando o LINQ
            if (Faturas.Any(f => f.Marcacao.Id == marcacaoAEliminar.Id))
            {
                MessageBox.Show("Não é possível eliminar uma marcação que já foi faturada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja eliminar a marcação seleccionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, eliminar a marcação da lista de marcações
                Marcacoes.Remove(marcacaoAEliminar);

                // Enviar o email de cancelamento
                await EnviarEmailAsync(marcacaoAEliminar.Cliente, marcacaoAEliminar);
            }

            // Actualizar a lista de marcações
            InitLista();

            // Limpar labels
            lblCliente.Text = null;
            lblVeiculo.Text = null;
            listBoxServicos.DataSource = null;
            lblData.Text = null;
        }

        /// <summary>
        /// Enviar um email assíncrono para o cliente com a confirmação do cancelamento da marcação.
        /// </summary>
        /// <param name="cliente">O cliente que receberá o email.</param>
        /// <param name="marcacao">A marcação que foi cancelada.</param>
        private async Task EnviarEmailAsync(Cliente cliente, Marcacao marcacao)
        {
            string servicos = string.Join(", ", marcacao.Servicos.Select(s => s.Descricao));

            await Task.Run(() =>
            {
                try
                {
                    // Obter a senha do email a partir da variável de ambiente
                    string senhaEmail = Environment.GetEnvironmentVariable("SENHA_EMAIL");

                    MailMessage mail = new MailMessage("Silvia.Oliveira.32376@formandos.cinel.pt", cliente.Email);
                    SmtpClient client = new SmtpClient();

                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("Silvia.Oliveira.32376@formandos.cinel.pt", senhaEmail);
                    client.Host = "smtp.office365.com";
                    client.EnableSsl = true;

                    mail.Subject = "Cancelamento de Marcação";
                    mail.Body = $"Caro(a) {cliente.Nome},\n\n" +
                                $"Confirmamos o cancelamento da sua marcação com os seguintes dados:\n\n" +
                                $"- Data e Hora: {marcacao.Data.ToString("dd/MM/yyyy")} às {marcacao.Data.ToString("HH:mm")}\n" +
                                $"- Veículo: {marcacao.Veiculo.MarcaModelo}\n" +
                                $"- Serviços: {servicos}\n\n" +
                                "Atenciosamente,\nEquipa Garage 87";

                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao enviar o email: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se a textBox está vazia
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, insira um nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obter o nome da textBox e converter para minúsculas para não ser case sensitive
            string nome = txtCliente.Text.ToLower();

            // Procurar as marcações cujo nome do cliente contém o nome indicado usando o LINQ
            // Converter o nome do cliente para minúsculas antes de fazer a comparação para não ser case sensitive
            List<Marcacao> marcacoes = Marcacoes.Where(m => m.Cliente.NomeCompleto.ToLower().Contains(nome)).ToList();

            // Verificar se alguma marcação foi encontrada
            if (marcacoes.Count == 0)
            {
                MessageBox.Show("Nenhuma marcação encontrada com o nome do cliente indicado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Atualizar a listBoxMarcacoes para mostrar apenas as marcações encontradas
            listBoxMarcacoes.DataSource = null;
            listBoxMarcacoes.DataSource = marcacoes;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a textBox
            txtCliente.Text = "";

            // Atualizar a listBoxMarcacoes para mostrar todas as marcações
            InitLista();
        }
    }
}
