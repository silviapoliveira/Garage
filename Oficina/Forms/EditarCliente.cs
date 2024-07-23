using Biblioteca;

namespace Oficina.Forms
{
    public partial class EditarCliente : Form
    {
        #region Variáveis

        Cliente _editado; // o cliente que está a ser editado
        List<Cliente> Clientes; // lista de todos os clientes

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário EditarCliente e preencher os campos do formulário com os dados do cliente que está a ser editado.
        /// </summary>
        /// <param name="editado">O cliente que está a ser editado.</param>
        /// <param name="clientes">A lista de clientes existentes.</param>
        public EditarCliente(Cliente editado, List<Cliente> clientes)
        {
            InitializeComponent();

            // Atribuir o parâmetro à variável correspondente
            _editado = editado;
            Clientes = clientes;

            // Preencher os campos do formulário com os dados do cliente que está a ser editado
            lblId.Text = editado.Id.ToString();
            txtNome.Text = editado.Nome;
            txtApelido.Text = editado.Apelido;
            txtMorada.Text = editado.Morada;
            txtTelemovel.Text = editado.Telemovel;
            txtEmail.Text = editado.Email;
            txtNif.Text = editado.Nif;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtApelido.Text) ||
                string.IsNullOrWhiteSpace(txtMorada.Text) ||
                string.IsNullOrWhiteSpace(txtTelemovel.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtNif.Text))
            {
                // Se algum campo não estiver preenchido, exibir uma mensagem de erro
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se o telemóvel é válido
            string erroTelemovel = Cliente.TelemovelValido(txtTelemovel.Text);
            if (erroTelemovel != null)
            {
                MessageBox.Show(erroTelemovel, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se o email é válido
            if (!Cliente.EmailValido(txtEmail.Text))
            {
                MessageBox.Show("Por favor, insira um email válido (no formato example@example.com).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se o NIF é válido
            string erroNif = Cliente.NifValido(txtNif.Text, Clientes.Where(c => c.Id != _editado.Id).ToList());
            if (erroNif != null)
            {
                MessageBox.Show(erroNif, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, actualizar os dados do cliente
                _editado.Nome = txtNome.Text;
                _editado.Apelido = txtApelido.Text;
                _editado.Morada = txtMorada.Text;
                _editado.Telemovel = txtTelemovel.Text;
                _editado.Email = txtEmail.Text;
                _editado.Nif = txtNif.Text;

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
