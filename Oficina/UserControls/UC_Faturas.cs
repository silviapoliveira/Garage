using Biblioteca;
using Oficina.Forms;
using System.Drawing.Printing;

namespace Oficina.UserControls
{
    public partial class UC_Faturas : UserControl
    {
        #region Propriedades

        public List<Fatura> Faturas { get; set; } // lista de todas as faturas

        public List<Marcacao> Marcacoes { get; set; } // lista de todas as marcações

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do User Control UC_Faturas e inicializar a lista de faturas.
        /// </summary>
        /// <param name="faturas">A lista de faturas existentes. Se for null, uma nova lista de Fatura será criada.</param>
        /// <param name="marcacoes">A lista de marcações existentes. Se for null, uma nova lista de Marcacao será criada.</param>
        public UC_Faturas(List<Fatura> faturas, List<Marcacao> marcacoes)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Faturas = faturas ?? new List<Fatura>(); // se faturas for null, uma nova lista de Fatura será criada e atribuída a Faturas, evitando assim a excepção
            Marcacoes = marcacoes ?? new List<Marcacao>(); // se marcacoes for null, uma nova lista de Marcacao será criada e atribuída a Marcacoes, evitando assim a excepção

            InitializeComponent();

            // Inicializar a lista de faturas
            InitLista();
        }

        // Método para inicializar a lista de faturas
        public void InitLista()
        {
            // Limpar o interface e permitir atualizar a lista
            listBoxFaturas.DataSource = null;

            // Ordenar a lista de faturas por data usando o LINQ
            List<Fatura> faturasOrdenadas = Faturas.OrderBy(f => f.Data).ToList();

            // Atribuir a lista ordenada de faturas ao DataSource do listBox
            listBoxFaturas.DataSource = faturasOrdenadas;
        }

        private void listBoxFaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se uma fatura está selecionada
            if (listBoxFaturas.SelectedItem is Fatura faturaSelecionada)
            {
                // Atualizar as labels com os dados da fatura
                lblNumero.Text = faturaSelecionada.Numero.ToString();
                lblData.Text = faturaSelecionada.Data.ToString("dd/MM/yyyy");
                lblCliente.Text = faturaSelecionada.Marcacao.Cliente.NomeCompleto;
                lblMorada.Text = faturaSelecionada.Marcacao.Cliente.Morada;
                lblNif.Text = faturaSelecionada.Marcacao.Cliente.Nif;

                // Atualizar a listBox de serviços com os serviços da marcação por ordem alfabética usando o LINQ
                listBoxServicos.DataSource = null;
                List<Servico> servicosOrdenados = faturaSelecionada.Marcacao.Servicos.OrderBy(s => s.Descricao).ToList();
                listBoxServicos.DataSource = servicosOrdenados;
                listBoxServicos.DisplayMember = "Descricao";

                // Atualizar a label do total com o valor total da fatura
                lblTotal.Text = $"{faturaSelecionada.ValorAPagar():C2}";

                // Verificar se a fatura inclui um desconto
                if (faturaSelecionada.Marcacao.Servicos.Count > 1)
                {
                    // Atualizar a label do desconto
                    lblDesconto.Text = "(inclui 5% de desconto)";
                }
                else
                {
                    // Limpar a label do desconto
                    lblDesconto.Text = "";
                }
            }
        }

        private void btnEmitirFatura_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do formulário EmitirFatura
            EmitirFatura emitirFatura = new EmitirFatura(Faturas, Marcacoes);

            // Exibir o formulário
            emitirFatura.ShowDialog();

            // Atualizar a lista de faturas
            Faturas = emitirFatura.Faturas;
            InitLista();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Verificar se uma fatura foi selecionada
            if (listBoxFaturas.SelectedItem is Fatura faturaSelecionada)
            {
                // Definir o documento a ser impresso
                printDocument1.DocumentName = $"Fatura {faturaSelecionada.Numero}";

                // Remover o evento PrintPage existente
                printDocument1.PrintPage -= PrintPageHandler;

                // Adicionar o novo evento PrintPage
                printDocument1.PrintPage += PrintPageHandler;

                // Mostrar a janela de impressão
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma fatura para imprimir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Manipular o evento PrintPage para imprimir a fatura selecionada e evitar que haja sobreposição de impressões.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="ev">Os argumentos do evento PrintPage.</param>
        private void PrintPageHandler(object sender, PrintPageEventArgs ev)
        {
            if (listBoxFaturas.SelectedItem is Fatura faturaSelecionada)
            {
                float currentY = 100;  // A posição Y atual para desenhar
                float lineHeight = 20;  // A altura da linha

                // Carregar o logotipo
                Image logo = null;
                try
                {
                    logo = Image.FromFile("logo.png");  // caminho para a imagem do logotipo

                    // Redimensionar a imagem para 150 x 75 px
                    Image resizedLogo = new Bitmap(logo, new Size(150, 75));

                    // Calcular a posição X para centralizar o logotipo
                    float centerX = (ev.PageSettings.PrintableArea.Width - resizedLogo.Width) / 2;

                    // Desenhar o logotipo no topo da página, centralizado
                    ev.Graphics.DrawImage(resizedLogo, new PointF(centerX, 10));

                    // Atualizar a posição Y atual para abaixo do logotipo
                    currentY += resizedLogo.Height + 10;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao carregar o logotipo: " + ex.Message);
                    // Não retornar, continuar a impressão sem o logotipo
                }

                // Definir o que imprimir
                string fatura = $"GARAGE 87\n\n\n" +
                                $"Fatura Nº: {faturaSelecionada.Numero}\n" +
                                $"Data: {faturaSelecionada.Data.ToString("dd/MM/yyyy")}\n\n" +
                                $"Cliente: {faturaSelecionada.Marcacao.Cliente.NomeCompleto}\n" +
                                $"Morada: {faturaSelecionada.Marcacao.Cliente.Morada}\n" +
                                $"NIF: {faturaSelecionada.Marcacao.Cliente.Nif}\n\n";

                // Desenhar o texto no documento
                ev.Graphics.DrawString(fatura, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, currentY));

                // Calcular a altura do texto
                SizeF stringSize = ev.Graphics.MeasureString(fatura, new Font("Arial", 12, FontStyle.Bold));

                // Atualizar a posição Y atual
                currentY += stringSize.Height + 10;

                // Desenhar uma linha para separar os detalhes do cliente dos detalhes do serviço
                ev.Graphics.DrawLine(Pens.Black, new Point(100, (int)currentY), new Point(500, (int)currentY));

                // Continuar a imprimir o resto da fatura
                fatura = $"SERVIÇOS:\n";

                double totalSemTaxas = 0;
                double totalTaxas = 0;

                foreach (var servico in faturaSelecionada.Marcacao.Servicos)
                {
                    double preco = faturaSelecionada.Precos[servico];
                    double taxa = faturaSelecionada.Taxas[servico];
                    fatura += $"- {servico.Descricao} - Preço: {preco:C2} - IVA: {taxa}%\n";
                    totalSemTaxas += preco;
                    totalTaxas += preco * taxa / 100;
                }

                // Desenhar o texto no documento
                ev.Graphics.DrawString(fatura, new Font("Arial", 12), Brushes.Black, new PointF(100, currentY + 10));

                // Calcular a altura do texto
                stringSize = ev.Graphics.MeasureString(fatura, new Font("Arial", 12));

                // Atualizar a posição Y atual
                currentY += stringSize.Height + 20;

                // Desenhar uma linha para separar os serviços do total
                ev.Graphics.DrawLine(Pens.Black, new Point(100, (int)currentY), new Point(500, (int)currentY));

                fatura = $"Total sem IVA: {totalSemTaxas:C2}\n" +
                          $"IVA: {totalTaxas:C2}\n";

                // Verificar se a fatura inclui um desconto
                if (faturaSelecionada.Marcacao.Servicos.Count > 1)
                {
                    double desconto = (totalSemTaxas + totalTaxas) * 0.05;
                    fatura += $"Desconto: {desconto:C2}\n";
                }

                // Desenhar o texto no documento
                ev.Graphics.DrawString(fatura, new Font("Arial", 12), Brushes.Black, new PointF(100, currentY + 10));

                // Calcular a altura do texto
                stringSize = ev.Graphics.MeasureString(fatura, new Font("Arial", 12));

                // Atualizar a posição Y atual
                currentY += stringSize.Height;

                fatura = $"TOTAL c/ IVA: {faturaSelecionada.ValorAPagar():C2}";

                // Desenhar o texto no documento
                ev.Graphics.DrawString(fatura, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new PointF(100, currentY + 10));
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se a textBox está vazia ou se o NIF não tem 9 dígitos
            if (string.IsNullOrWhiteSpace(txtNif.Text) || txtNif.Text.Length != 9)
            {
                MessageBox.Show("Por favor, insira um NIF válido com 9 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obter o NIF da textBox
            string nif = txtNif.Text;

            // Procurar as faturas cujo NIF do cliente é igual ao NIF indicado usando o LINQ
            List<Fatura> faturas = Faturas.Where(f => f.Marcacao.Cliente.Nif == nif).ToList();

            // Verificar se alguma fatura foi encontrada
            if (faturas.Count == 0)
            {
                MessageBox.Show("Nenhuma fatura encontrada com o NIF do cliente indicado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Atualizar a listBoxFaturas para mostrar apenas as faturas encontradas
            listBoxFaturas.DataSource = null;
            listBoxFaturas.DataSource = faturas;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a textBox
            txtNif.Text = "";

            // Atualizar a listBoxFaturas para mostrar todas as faturas
            InitLista();
        }
    }
}
