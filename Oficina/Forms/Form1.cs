using Biblioteca;
using Oficina.Forms;
using Oficina.UserControls;

namespace Oficina
{
    public partial class Form1 : Form
    {
        #region Atributos

        int PanelWidth;
        bool isCollapsed;

        #endregion

        #region Propriedades

        public List<Cliente> Clientes { get; set; }

        public List<Veiculo> Veiculos { get; set; }

        public List<Funcionario> Funcionarios { get; set; }

        public List<Servico> Servicos { get; set; }

        public List<Marcacao> Marcacoes { get; set; }

        public List<Fatura> Faturas { get; set; }

        private Dados dados;

        #endregion

        public Form1()
        {
            InitializeComponent();

            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;

            Clientes = new List<Cliente>();

            // Carregar os dados quando a aplicação inicia
            dados = new Dados();

            Clientes = dados.CarregarClientes();
            Veiculos = dados.CarregarVeiculos();
            Funcionarios = dados.CarregarFuncionarios();
            Servicos = dados.CarregarServicos();
            Marcacoes = dados.CarregarMarcacoes();
            Faturas = dados.CarregarFaturas();

            UC_Inicio uci = new UC_Inicio(Clientes, Marcacoes, Faturas);
            AddControlsToPanel(uci);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Guardar os dados quando a aplicação está a ser encerrada
            dados.GuardarClientes(Clientes);
            dados.GuardarVeiculos(Veiculos);
            dados.GuardarFuncionarios(Funcionarios);
            dados.GuardarServicos(Servicos);
            dados.GuardarMarcacoes(Marcacoes);
            dados.GuardarFaturas(Faturas);

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;

                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;

                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        /// <summary>
        /// Mover o painel lateral para a posição do botão especificado.
        /// </summary>
        /// <param name="btn">O botão que determina a nova posição do painel lateral.</param>
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        /// <summary>
        /// Adicionar um controlo ao painel e configurar as suas propriedades.
        /// </summary>
        /// <param name="c">O controle a ser adicionado ao painel.</param>
        private void AddControlsToPanel(Control c)
        {
            // Definir as propriedades do user control
            c.Dock = DockStyle.Fill;
            c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c.AutoSize = true;
            c.Padding = new Padding(0);
            c.Margin = new Padding(0);
            c.MinimumSize = new Size(985, 580);
            c.MaximumSize = new Size(0, 0);

            // Adicionar o user control ao painel
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
            panelControls.PerformLayout(); // Ou panelControls.Refresh();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnInicio);
            UC_Inicio uci = new UC_Inicio(Clientes, Marcacoes, Faturas);
            AddControlsToPanel(uci);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnClientes);
            UC_Clientes ucc = new UC_Clientes(Clientes);
            AddControlsToPanel(ucc);
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVeiculos);
            UC_Veiculos ucv = new UC_Veiculos(Veiculos, Clientes);
            AddControlsToPanel(ucv);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFuncionarios);
            UC_Funcionarios ucf = new UC_Funcionarios(Funcionarios);
            AddControlsToPanel(ucf);
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnServicos);
            UC_Servicos ucs = new UC_Servicos(Servicos, Funcionarios);
            AddControlsToPanel(ucs);
        }

        private void btnMarcacoes_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnMarcacoes);
            UC_Marcacoes ucm = new UC_Marcacoes(Marcacoes, Clientes, Servicos, Faturas);
            AddControlsToPanel(ucm);
        }

        private void btnFaturas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFaturas);
            UC_Faturas ucfa = new UC_Faturas(Faturas, Marcacoes);
            AddControlsToPanel(ucfa);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("dd 'de' MMMM 'de' yyyy | HH:mm:ss");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do formulário Creditos
            Creditos formCreditos = new Creditos();

            // Exibir o formulário
            formCreditos.Show();
        }
    }
}
