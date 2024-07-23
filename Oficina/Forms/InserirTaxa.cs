namespace Oficina.Forms
{
    public partial class InserirTaxa : Form
    {
        #region Propriedades

        public double Taxa { get; private set; } // propriedade para armazenar a taxa inserida

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário InserirTaxa e definir o texto da label com a descrição do serviço.
        /// </summary>
        /// <param name="descricaoServico">A descrição do serviço (do tipo string) para o qual a taxa está a ser inserida.</param>
        public InserirTaxa(string descricaoServico)
        {
            InitializeComponent();

            // Definir o texto da lblTexto com a descrição do serviço
            lblTexto.Text = $"Por favor insira o IVA do serviço {descricaoServico}:";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar se a taxa inserida é um número válido entre 0 e 100
            if (!double.TryParse(txtTaxa.Text, out double taxa) || taxa < 0 || taxa > 100)
            {
                // Se a taxa não for um número válido ou não estiver entre 0 e 100, exibir uma mensagem de erro
                MessageBox.Show("Por favor, insira um número válido entre 0 e 100 para a taxa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Armazenar a taxa inserida e fechar o formulário
            Taxa = taxa;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Fechar o formulário sem armazenar a taxa
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
