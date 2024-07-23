using Biblioteca;

namespace Oficina.Forms
{
    public partial class CriarFuncionario : Form
    {
        #region Variáveis

        List<Funcionario> Funcionarios; // lista de todos os funcionários

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário CriarFuncionario e preencher automaticamente o ID do próximo funcionário.
        /// </summary>
        /// <param name="funcionarios">A lista de funcionários existentes.</param>
        public CriarFuncionario(List<Funcionario> funcionarios)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Funcionarios = funcionarios;

            InitializeComponent();

            // Preencher automaticamente o ID do próximo funcionário
            lblId.Text = Funcionario.ProximoId().ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtApelido.Text) ||
                string.IsNullOrWhiteSpace(txtFuncao.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                // Se algum campo não estiver preenchido, exibir uma mensagem de erro
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se o valor inserido como salário é um número válido
            double salario;
            if (!double.TryParse(txtSalario.Text, out salario) || salario < 0)
            {
                // Se o salário não for um valor numérico maior ou igual a 0, exibir uma mensagem de erro
                MessageBox.Show("Por favor, insira um valor numérico maior ou igual a 0 para o salário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar os dados do novo funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, criar um novo funcionário com os dados inseridos
                Funcionario novoFuncionario = new Funcionario
                {
                    Nome = txtNome.Text,
                    Apelido = txtApelido.Text,
                    Funcao = txtFuncao.Text,
                    Salario = salario
                };

                // Adicionar o novo funcionário à lista de funcionários
                Funcionarios.Add(novoFuncionario);

                // Fechar o formulário
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Perguntar ao utilizador se deseja sair sem guardar as alterações
            var resultado = MessageBox.Show("Tem a certeza que deseja sair sem guardar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Fechar o formulário
                this.Close();
            }
        }
    }
}
