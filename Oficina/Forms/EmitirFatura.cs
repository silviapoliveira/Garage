using Biblioteca;

namespace Oficina.Forms
{
    public partial class EmitirFatura : Form
    {
        #region Propriedades

        public List<Fatura> Faturas { get; set; } // lista de todas as faturas

        public List<Marcacao> Marcacoes { get; set; } // lista de todas as marcações

        public Dictionary<Servico, double> PrecosInseridos { get; set; } // dicionário para armazenar os preços inseridos

        public Dictionary<Servico, double> TaxasInseridas { get; set; } // dicionário para armazenar as taxas inseridas

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário EmitirFatura e configurar a interface do utilizador.
        /// </summary>
        /// <param name="faturas">A lista de todas as faturas existentes.</param>
        /// <param name="marcacoes">A lista de todas as marcações existentes.</param>
        public EmitirFatura(List<Fatura> faturas, List<Marcacao> marcacoes)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Faturas = faturas ?? new List<Fatura>(); // se faturas for null, uma nova lista de Fatura será criada e atribuída a Faturas, evitando assim a excepção
            Marcacoes = marcacoes ?? new List<Marcacao>(); // se marcacoes for null, uma nova lista de Marcacao será criada e atribuída a Marcacoes, evitando assim a excepção

            // Inicializar os dicionários
            PrecosInseridos = new Dictionary<Servico, double>();
            TaxasInseridas = new Dictionary<Servico, double>();

            InitializeComponent();

            // Inicializar a comboBox de marcações
            InitComboBox();

            // Definir as propriedades do DataGridView
            dgvServicos.ColumnCount = 3;
            dgvServicos.Columns[0].Name = "Descrição";
            dgvServicos.Columns[1].Name = "Preço";
            dgvServicos.Columns[2].Name = "IVA";

            // Inicialmente, o DataGridView está invisível
            dgvServicos.Visible = false;
        }

        /// <summary>
        /// Inicializar a comboBox de marcações com as marcações que ainda não foram faturadas.
        /// </summary>
        public void InitComboBox()
        {
            // Obter as marcações que ainda não foram faturadas usando o LINQ
            List<Marcacao> marcacoesNaoFaturadas = Marcacoes.Where(m => !Faturas.Any(f => f.Marcacao == m)).ToList();

            // Verificar se a lista está vazia
            if (marcacoesNaoFaturadas.Count == 0)
            {
                // Se a lista estiver vazia, indicar que não existem marcações por faturar
                comboBoxMarcacao.Items.Add("Sem marcações por faturar");
                comboBoxMarcacao.SelectedIndex = 0;
                comboBoxMarcacao.Enabled = false;
            }
            else
            {
                // Se a lista não estiver vazia, adicionar a opção "Selecione uma marcação"
                comboBoxMarcacao.Items.Add("Selecione uma marcação");
                comboBoxMarcacao.SelectedIndex = 0;

                // Ordenar a lista de marcações por data usando o LINQ
                List<Marcacao> marcacoesOrdenadas = marcacoesNaoFaturadas.OrderBy(m => m.Data).ToList();

                // Adicionar as marcações não faturadas à comboBox
                foreach (var marcacao in marcacoesOrdenadas)
                {
                    comboBoxMarcacao.Items.Add(marcacao);
                }
            }
        }

        private void comboBoxMarcacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se uma marcação está selecionada
            if (comboBoxMarcacao.SelectedItem is Marcacao marcacaoSelecionada)
            {
                // Atualizar as labels com os dados da marcação
                lblCliente.Text = marcacaoSelecionada.Cliente.NomeCompleto;
                lblVeiculo.Text = marcacaoSelecionada.Veiculo.MarcaModelo;
                lblData.Text = marcacaoSelecionada.Data.ToString("dd/MM/yyyy HH:mm");

                // Limpar o DataGridView
                dgvServicos.Rows.Clear();

                // Para cada serviço na marcação, adicionar uma linha ao DataGridView
                foreach (var servico in marcacaoSelecionada.Servicos)
                {
                    double preco;
                    double taxa;

                    // Verificar se o serviço existe nos dicionários
                    if (PrecosInseridos.ContainsKey(servico) && TaxasInseridas.ContainsKey(servico))
                    {
                        // Se o serviço existir nos dicionários, usar os preços e taxas dos dicionários
                        preco = PrecosInseridos[servico];
                        taxa = TaxasInseridas[servico];
                    }
                    else
                    {
                        // Se o serviço não existir nos dicionários, usar os preços e taxas originais do serviço
                        preco = servico.Preco;
                        taxa = servico.Taxa;
                    }

                    string[] row = new string[] { servico.Descricao, preco.ToString(), taxa.ToString() };
                    dgvServicos.Rows.Add(row);
                }

                // Tornar o DataGridView visível
                dgvServicos.Visible = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar se uma marcação foi selecionada
            if (comboBoxMarcacao.SelectedItem is Marcacao marcacaoSelecionada)
            {
                // Para cada serviço na marcação, pedir ao utilizador para inserir o preço e a taxa
                foreach (var servico in marcacaoSelecionada.Servicos)
                {
                    // Criar uma nova instância do formulário InserirPreco
                    InserirPreco formInserirPreco = new InserirPreco(servico.Descricao);

                    // Exibir o formulário e verificar se o utilizador confirmou a inserção do preço
                    if (formInserirPreco.ShowDialog() == DialogResult.OK)
                    {
                        // Armazenar o preço inserido no dicionário
                        PrecosInseridos[servico] = formInserirPreco.Preco;
                    }
                    else
                    {
                        // Se o utilizador cancelar a inserção do preço, retornar sem emitir fatura
                        return;
                    }

                    // Criar uma nova instância do formulário InserirTaxa
                    InserirTaxa formInserirTaxa = new InserirTaxa(servico.Descricao);

                    // Exibir o formulário e verificar se o utilizador confirmou a inserção da taxa
                    if (formInserirTaxa.ShowDialog() == DialogResult.OK)
                    {
                        // Armazenar a taxa inserida no dicionário
                        TaxasInseridas[servico] = formInserirTaxa.Taxa;
                    }
                    else
                    {
                        // Se o utilizador cancelar a inserção da taxa, retornar sem emitir fatura
                        return;
                    }
                }

                // Atualizar o DataGridView com os novos preços e taxas
                comboBoxMarcacao_SelectedIndexChanged(null, null);

                // Mostrar uma mensagem de confirmação
                var resultado = MessageBox.Show("Tem a certeza que deseja emitir a fatura com a marcação selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Se o utilizador confirmar, criar uma nova fatura e adicionar à lista de faturas
                    Fatura novaFatura = new Fatura(Faturas.Count + 1, DateTime.Now, marcacaoSelecionada, PrecosInseridos, TaxasInseridas);
                    Faturas.Add(novaFatura);

                    // Fechar o formulário
                    this.Close();
                }
                else
                {
                    // Se o utilizador não confirmar, redefinir o preço e a taxa para zero
                    foreach (var servico in marcacaoSelecionada.Servicos)
                    {
                        servico.Preco = 0;
                        servico.Taxa = 0;
                    }

                    // Fechar o formulário
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma marcação para faturar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja sair sem emitir fatura?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, fechar o formulário
                this.Close();
            }
        }
    }
}
