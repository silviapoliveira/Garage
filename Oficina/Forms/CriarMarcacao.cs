using Biblioteca;
using System.Net;
using System.Net.Mail;

namespace Oficina.Forms
{
    public partial class CriarMarcacao : Form
    {
        public List<Marcacao> Marcacoes; // lista de todas as marcações
        List<Cliente> Clientes; // lista de todos os clientes
        List<Servico> Servicos; // lista de todos os serviços

        /// <summary>
        /// Inicializar uma nova instância do formulário CriarMarcacao, preencher automaticamente o ID da próxima marcação e configurar os campos do formulário.
        /// </summary>
        /// <param name="marcacoes">A lista de marcações existentes.</param>
        /// <param name="clientes">A lista de clientes existentes.</param>
        /// <param name="servicos">A lista de serviços existentes.</param>
        public CriarMarcacao(List<Marcacao> marcacoes, List<Cliente> clientes, List<Servico> servicos)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Marcacoes = marcacoes ?? new List<Marcacao>(); // se marcacoes for null, uma nova lista de Marcacao será criada e atribuída a Marcacoes, evitando assim a excepção
            Clientes = clientes;
            Servicos = servicos;

            InitializeComponent();

            // Preencher automaticamente o ID da próxima marcação
            lblId.Text = Marcacao.ProximoId().ToString();

            // Configurar o ComboBox dos clientes por ordem alfabética usando o LINQ
            Clientes = clientes.OrderBy(c => c.NomeCompleto).ToList();
            comboBoxCliente.DataSource = Clientes;
            comboBoxCliente.DisplayMember = "NomeCompleto";

            // Configurar a listBox dos serviços disponíveis por ordem alfabética usando o LINQ
            List<Servico> servicosOrdenados = new List<Servico>(Servicos.OrderBy(s => s.Descricao)); // criar uma cópia da lista de serviços e ordená-la
            listBoxDisponiveis.DataSource = servicosOrdenados;

            // Inicializar a listBox dos serviços selecionados com uma lista vazia
            listBoxSeleccionados.DataSource = new List<Servico>();
            listBoxSeleccionados.DisplayMember = "Descricao";

            // Configurar o DateTimePicker para permitir a seleção de data
            dtpData.Format = DateTimePickerFormat.Short;

            // Configurar o ComboBox das horas
            for (int i = 8; i <= 19; i++)
            {
                comboBoxHoras.Items.Add(i.ToString("00") + ":00");
                if (i != 19) // Não adicionar 19:30
                {
                    comboBoxHoras.Items.Add(i.ToString("00") + ":30");
                }
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o cliente selecionado no ComboBox
            Cliente clienteSelecionado = (Cliente)comboBoxCliente.SelectedItem;

            // Atualizar o ComboBox dos veículos para mostrar apenas os veículos associados ao cliente selecionado por ordem alfabética usando o LINQ
            comboBoxVeiculo.DataSource = clienteSelecionado.Veiculos.OrderBy(v => v.MarcaModelo).ToList();
            comboBoxVeiculo.DisplayMember = "MarcaModelo";
        }

        private void OrganizarListBoxes()
        {
            // Obter as listas de serviços das listBoxes
            List<Servico> servicosDisponiveis = (List<Servico>)listBoxDisponiveis.DataSource;
            List<Servico> servicosSeleccionados = (List<Servico>)listBoxSeleccionados.DataSource;

            // Ordenar as listas de serviços usando o LINQ
            servicosDisponiveis = servicosDisponiveis.OrderBy(s => s.Descricao).ToList();
            servicosSeleccionados = servicosSeleccionados.OrderBy(s => s.Descricao).ToList();

            // Atualizar as listBoxes
            listBoxDisponiveis.DataSource = null;
            listBoxDisponiveis.DataSource = servicosDisponiveis;
            listBoxDisponiveis.DisplayMember = "Descricao";

            listBoxSeleccionados.DataSource = null;
            listBoxSeleccionados.DataSource = servicosSeleccionados;
            listBoxSeleccionados.DisplayMember = "Descricao";
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            // Obter o serviço selecionado na listBoxDisponiveis
            Servico servicoSelecionado = (Servico)listBoxDisponiveis.SelectedItem;

            // Verificar se um serviço foi selecionado
            if (servicoSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Remover o serviço da listBoxDisponiveis e adicioná-lo à listBoxSeleccionados
            ((List<Servico>)listBoxDisponiveis.DataSource).Remove(servicoSelecionado);
            List<Servico> servicosSeleccionados = (List<Servico>)listBoxSeleccionados.DataSource;
            servicosSeleccionados.Add(servicoSelecionado);

            // Atualizar as listBoxes
            OrganizarListBoxes();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            // Obter o serviço selecionado na listBoxSeleccionados
            Servico servicoSelecionado = (Servico)listBoxSeleccionados.SelectedItem;

            // Verificar se um serviço foi selecionado
            if (servicoSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Remover o serviço da listBoxSeleccionados e adicioná-lo à listBoxDisponiveis
            List<Servico> servicosSeleccionados = (List<Servico>)listBoxSeleccionados.DataSource;
            servicosSeleccionados.Remove(servicoSelecionado);
            ((List<Servico>)listBoxDisponiveis.DataSource).Add(servicoSelecionado);

            // Atualizar as listBoxes
            OrganizarListBoxes();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar se um cliente, um veículo e pelo menos um serviço foram selecionados
            if (comboBoxCliente.SelectedItem == null || comboBoxVeiculo.SelectedItem == null || listBoxSeleccionados.Items.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um cliente, um veículo e pelo menos um serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se uma data e uma hora foram selecionadas
            if (dtpData.Value.Date == null || comboBoxHoras.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma data e uma hora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Combinar a data do dtpData com a hora do comboBoxHoras
            DateTime dataMarcacao = dtpData.Value.Date.Add(TimeSpan.Parse((string)comboBoxHoras.SelectedItem));

            // Verificar se a data da marcação não é anterior à data e hora atuais
            if (dataMarcacao < DateTime.Now)
            {
                MessageBox.Show("A data e hora da marcação não podem ser anteriores à data e hora atuais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se a data da marcação é um domingo
            if (dataMarcacao.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Não é possível fazer marcações ao domingo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar a nova marcação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, criar uma nova marcação com os dados inseridos
                Marcacao novaMarcacao = new Marcacao();
                novaMarcacao.Cliente = (Cliente)comboBoxCliente.SelectedItem;
                novaMarcacao.Veiculo = (Veiculo)comboBoxVeiculo.SelectedItem;
                novaMarcacao.Servicos = listBoxSeleccionados.Items.Cast<Servico>().ToList();
                novaMarcacao.Data = dataMarcacao;

                // Adicionar a nova marcação à lista de marcações
                Marcacoes.Add(novaMarcacao);

                // Enviar o email de confirmação
                await EnviarEmailAsync((Cliente)comboBoxCliente.SelectedItem, novaMarcacao);

                // Fechar o formulário
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Perguntar ao utilizador se deseja sair sem guardar as alterações
            var resultado = MessageBox.Show("Tem a certeza que deseja sair sem guardar a nova marcação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Fechar o formulário
                this.Close();
            }
        }

        /// <summary>
        /// Enviar um email assíncrono para o cliente com a confirmação da criação da marcação.
        /// </summary>
        /// <param name="cliente">O cliente que receberá o email.</param>
        /// <param name="marcacao">A marcação que foi criada.</param>
        private async Task EnviarEmailAsync(Cliente cliente, Marcacao marcacao)
        {
            string servicos = string.Join(", ", marcacao.Servicos.Select(s => s.Descricao));

            await Task.Run(() =>
            {
                try
                {
                    // Obter a senha do email a partir da variável de ambiente
                    string senhaEmail = Environment.GetEnvironmentVariable("SENHA_EMAIL");

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("Silvia.Oliveira.32376@formandos.cinel.pt");
                    mail.To.Add(cliente.Email);
                    mail.Subject = "Confirmação de Marcação";
                    mail.Body = $"Caro(a) {cliente.Nome},\n\n" +
                                $"Confirmamos a sua marcação com os seguintes dados:\n\n" +
                                $"- Data e Hora: {marcacao.Data.ToString("dd/MM/yyyy")} às {marcacao.Data.ToString("HH:mm")}\n" +
                                $"- Veículo: {marcacao.Veiculo.MarcaModelo}\n" +
                                $"- Serviços: {servicos}\n\n" +
                                "Atenciosamente,\nEquipa Garage 87";

                    SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                    smtp.Credentials = new NetworkCredential("Silvia.Oliveira.32376@formandos.cinel.pt", senhaEmail);
                    smtp.EnableSsl = true;

                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao enviar o email: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
    }
}
