using Biblioteca;

namespace Oficina.Forms
{
    public partial class CriarCliente : Form
    {
        #region Variáveis

        List<Cliente> Clientes; // lista de todos os clientes

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário CriarCliente e preencher automaticamente o ID do próximo cliente.
        /// </summary>
        /// <param name="clientes">A lista de clientes existentes.</param>
        public CriarCliente(List<Cliente> clientes)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Clientes = clientes;

            InitializeComponent();
            
            // Preencher automaticamente o ID do próximo cliente
            lblId.Text = Cliente.ProximoId().ToString();
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
            string erroNif = Cliente.NifValido(txtNif.Text, Clientes);
            if (erroNif != null)
            {
                MessageBox.Show(erroNif, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar os dados do novo cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, criar um novo cliente com os dados inseridos
                Cliente novoCliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Apelido = txtApelido.Text,
                    Morada = txtMorada.Text,
                    Telemovel = txtTelemovel.Text,
                    Email = txtEmail.Text,
                    Nif = txtNif.Text
                };

                // Adiciona o novo cliente à lista de clientes
                Clientes.Add(novoCliente);

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
