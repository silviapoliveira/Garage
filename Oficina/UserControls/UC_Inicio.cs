using Biblioteca;

namespace Oficina.UserControls
{
    public partial class UC_Inicio : UserControl
    {
        #region Propriedades

        public List<Cliente> Clientes { get; set; }

        public List<Marcacao> Marcacoes { get; set; }

        public List<Fatura> Faturas { get; set; }

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do User Control UC_Inicio e atualiza as estatísticas.
        /// </summary>
        /// <param name="clientes">A lista de clientes existentes.</param>
        /// <param name="marcacoes">A lista de marcações existentes.</param>
        /// <param name="faturas">A lista de faturas existentes.</param>
        public UC_Inicio(List<Cliente> clientes, List<Marcacao> marcacoes, List<Fatura> faturas)
        {
            InitializeComponent();

            Clientes = clientes;
            Marcacoes = marcacoes;
            Faturas = faturas;

            AtualizarEstatisticas();
        }

        /// <summary>
        /// Atualizar as estatísticas exibidas na interface do usuário, incluindo o número total de clientes, o número total de marcações e o valor total faturado.
        /// </summary>
        private void AtualizarEstatisticas()
        {
            // Número total de clientes
            if (Clientes != null)
            {
                lblTotalClientes.Text = Clientes.Count.ToString();
            }
            else
            {
                lblTotalClientes.Text = "0";
            }


            // Número total de marcações
            if (Marcacoes != null)
            {
                lblTotalMarcacoes.Text = Marcacoes.Count.ToString();
            }
            else
            {
                lblTotalMarcacoes.Text = "0";
            }

            // Valor total faturado
            double totalFaturado = 0;
            if (Faturas != null)
            {
                totalFaturado = Faturas.Sum(f => f.ValorAPagar());
            }

            lblTotalFaturado.Text = $"{totalFaturado.ToString("F2")}€";
        }
    }
}
