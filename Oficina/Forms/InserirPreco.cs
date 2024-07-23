namespace Oficina.Forms
{
    public partial class InserirPreco : Form
    {
        #region Propriedades

        public double Preco { get; private set; } // propriedade para armazenar o preço inserido

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário InserirPreco e definir o texto da label com a descrição do serviço.
        /// </summary>
        /// <param name="descricaoServico">A descrição do serviço (do tipo string) para o qual o preço está a ser inserido.</param>
        public InserirPreco(string descricaoServico)
        {
            InitializeComponent();

            // Definir o texto da lblTexto com a descrição do serviço
            lblTexto.Text = $"Por favor insira o preço do serviço {descricaoServico}:";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar se o preço inserido é um número válido
            if (!double.TryParse(txtPreco.Text, out double preco) || preco < 0)
            {
                MessageBox.Show("Por favor, insira um número válido para o preço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Armazenar o preço inserido e fechar o formulário
            Preco = preco;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Fechar o formulário sem armazenar o preço
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
