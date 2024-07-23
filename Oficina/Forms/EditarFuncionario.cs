using Biblioteca;

namespace Oficina.Forms
{
    public partial class EditarFuncionario : Form
    {
        #region Variáveis

        Funcionario _editado; // o funcionário que está a ser editado

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário EditarFuncionario e preencher os campos do formulário com os dados do funcionário que está a ser editado.
        /// </summary>
        /// <param name="editado">O funcionário que está a ser editado.</param>
        public EditarFuncionario(Funcionario editado)
        {
            InitializeComponent();

            // Atribuir o parâmetro à variável correspondente
            _editado = editado;


            // Preencher os campos do formulário com os dados do funcionário que está a ser editado
            lblId.Text = editado.Id.ToString();
            txtNome.Text = editado.Nome;
            txtApelido.Text = editado.Apelido;
            txtFuncao.Text = editado.Funcao;
            txtSalario.Text = editado.Salario.ToString();
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
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, actualizar os dados do funcionário
                _editado.Nome = txtNome.Text;
                _editado.Apelido = txtApelido.Text;
                _editado.Funcao = txtFuncao.Text;
                _editado.Salario = salario;

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
