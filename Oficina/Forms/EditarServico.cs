using Biblioteca;

namespace Oficina.Forms
{
    public partial class EditarServico : Form
    {
        #region Variáveis

        Servico _editado; // serviço que está a ser editado
        List<Funcionario> Funcionarios; // lista de todos os funcionários

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário EditarServico e preencher os campos do formulário com os dados do serviço que está a ser editado.
        /// </summary>
        /// <param name="editado">O serviço que está a ser editado.</param>
        /// <param name="funcionarios">A lista de todos os funcionários existentes.</param>
        public EditarServico(Servico editado, List<Funcionario> funcionarios)
        {
            InitializeComponent();

            // Atribui os parâmetros às variáveis correspondentes
            Funcionarios = funcionarios;
            _editado = editado;

            // Preencher os campos do formulário com os dados do serviço que está a ser editado
            lblId.Text = editado.Id.ToString();
            txtDescricao.Text = editado.Descricao;

            // Ordenar a lista de funcionários por nome
            Funcionarios = funcionarios.OrderBy(f => f.NomeFuncao).ToList();

            // Configurar o ComboBox dos funcionários
            comboBoxFuncionarios.DataSource = Funcionarios;
            comboBoxFuncionarios.DisplayMember = "NomeFuncao";
            comboBoxFuncionarios.SelectedItem = editado.FuncionarioAtribuido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar se foi fornecida uma descrição
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, introduza uma descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se um funcionário foi selecionado
            if (comboBoxFuncionarios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Remover o serviço da lista de serviços do funcionário antigo
            if (_editado.FuncionarioAtribuido != null)
            {
                _editado.FuncionarioAtribuido.Servicos.Remove(_editado);
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, actualizar os dados do serviço
                _editado.Descricao = txtDescricao.Text;

                // Actualizar o funcionário atribuído ao serviço
                Funcionario novoFuncionario = (Funcionario)comboBoxFuncionarios.SelectedItem;
                novoFuncionario.Servicos.Add(_editado);
                _editado.FuncionarioAtribuido = novoFuncionario;

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
