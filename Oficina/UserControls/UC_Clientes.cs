using Biblioteca;
using Oficina.Forms;

namespace Oficina.UserControls
{
    public partial class UC_Clientes : UserControl
    {
        #region Propriedades

        public List<Cliente> Clientes { get; set; } // lista de todos os clientes

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do User Control UC_Clientes e inicializar a lista de clientes.
        /// </summary>
        /// <param name="clientes">A lista de clientes existentes.</param>
        public UC_Clientes(List<Cliente> clientes)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Clientes = clientes;

            InitializeComponent();

            // Inicializar a lista de clientes
            InitLista();
        }

        // Método para inicializar a lista de clientes
        public void InitLista()
        {
            // Limpar o interface e permitir atualizar a lista
            listBoxClientes.DataSource = null;

            // Ordenar a lista de clientes por nome completo usando o LINQ
            List<Cliente> clientesOrdenados = Clientes.OrderBy(c => c.NomeCompleto).ToList();

            // Atribuir a lista ordenada de clientes ao DataSource do listBox
            listBoxClientes.DataSource = clientesOrdenados;

            // Definir a propriedade que será exibida no listBox
            listBoxClientes.DisplayMember = "NomeCompleto";
        }

        // Evento que ocorre quando o item selecionado no listBox muda
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se um cliente está selecionado
            if (listBoxClientes.SelectedItem is Cliente clienteSelecionado)
            {
                // Atualizar as labels com os dados do cliente
                lblClienteNome.Text = clienteSelecionado.NomeCompleto;
                lblClienteMorada.Text = clienteSelecionado.Morada;
                lblClienteTelemovel.Text = clienteSelecionado.Telemovel.ToString();
                lblClienteEmail.Text = clienteSelecionado.Email;
                lblClienteNif.Text = clienteSelecionado.Nif.ToString();

                // Verificar se o cliente tem veículos associados
                if (clienteSelecionado.Veiculos != null && clienteSelecionado.Veiculos.Count > 0)
                {
                    // Se tiver, exibir os veículos na listBox por ordem alfabética usando o LINQ
                    List<Veiculo> veiculosOrdenados = clienteSelecionado.Veiculos.OrderBy(v => v.MarcaModelo.ToString()).ToList();

                    listBoxVeiculos.DataSource = veiculosOrdenados;
                    listBoxVeiculos.DisplayMember = "MarcaModelo";
                }
                else
                {
                    // Se não tiver, exibir uma mensagem a indicar que não há veículos associados
                    listBoxVeiculos.DataSource = new List<string> { "Este cliente não tem veículos associados" };
                }
            }
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário CriarCliente
            CriarCliente criarCliente = new CriarCliente(Clientes);

            // Exibir o formulário
            criarCliente.ShowDialog();

            // Actualizar a lista de clientes
            InitLista();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            // Obter o cliente selecionado no listBox
            Cliente clienteAEditar = (Cliente)listBoxClientes.SelectedItem;

            Cliente editado = null;

            // Verificar se um cliente foi selecionado
            if (clienteAEditar != null)
            {
                // Procurar o cliente na lista de clientes
                foreach (Cliente cliente in Clientes)
                {
                    if (clienteAEditar.Id == cliente.Id)
                    {
                        // Se encontrar, atribuir o cliente à variável editado
                        editado = cliente;
                    }
                }

                // Cria uma nova instância do formulário EditarCliente
                EditarCliente editarCliente = new EditarCliente(editado, Clientes);

                // Exibir o formulário
                editarCliente.ShowDialog();

                // Actualizar a lista de clientes
                InitLista();
            }
            else
            {
                // Se nenhum cliente for selecionado, exibir uma mensagem de erro
                MessageBox.Show("Selecione um cliente para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            // Procurar o cliente com o NIF indicado usando o LINQ
            Cliente cliente = Clientes.SingleOrDefault(c => c.Nif == nif);

            // Verificar se o cliente foi encontrado
            if (cliente == null)
            {
                MessageBox.Show("Nenhum cliente encontrado com o NIF indicado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Atualizar a listBoxClientes para mostrar apenas o cliente encontrado
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = new List<Cliente> { cliente };
            listBoxClientes.DisplayMember = "NomeCompleto";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a textBox
            txtNif.Text = "";

            // Atualizar a listBoxClientes para mostrar todos os clientes
            InitLista();
        }
    }
}
