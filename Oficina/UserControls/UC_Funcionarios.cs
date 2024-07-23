using Biblioteca;
using Oficina.Forms;

namespace Oficina.UserControls
{
    public partial class UC_Funcionarios : UserControl
    {
        #region Propriedades

        public List<Funcionario> Funcionarios { get; set; } // lista de todos os funcionários

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do User Control UC_Funcionarios e inicializar a lista de funcionários.
        /// </summary>
        /// <param name="funcionarios">A lista de funcionários existentes.</param>
        public UC_Funcionarios(List<Funcionario> funcionarios)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Funcionarios = funcionarios;

            InitializeComponent();

            // Inicializar a lista de funcionários
            InitLista();
        }

        // Método para inicializar a lista de funcionários
        public void InitLista()
        {
            // Limpar o interface e permitir atualizar a lista
            listBoxFuncionarios.DataSource = null;

            // Ordenar a lista de funcionários por nome completo usando o LINQ
            List<Funcionario> funcionariosOrdenados = Funcionarios.OrderBy(f => f.NomeCompleto).ToList();

            // Atribuir a lista ordenada de funcionários ao DataSource do listBox
            listBoxFuncionarios.DataSource = funcionariosOrdenados;

            // Definir a propriedade que será exibida no listBox
            listBoxFuncionarios.DisplayMember = "NomeCompleto";
        }

        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se um funcionário está selecionado
            if (listBoxFuncionarios.SelectedItem is Funcionario funcionarioSelecionado)
            {
                // Atualizar as labels com os dados do funcionário
                lblNome.Text = funcionarioSelecionado.NomeCompleto;
                lblFuncao.Text = funcionarioSelecionado.Funcao;
                lblSalario.Text = funcionarioSelecionado.Salario.ToString() + "€";

                // Verificar se o funcionário tem serviços associados
                if (funcionarioSelecionado.Servicos != null && funcionarioSelecionado.Servicos.Count > 0)
                {
                    // Se tiver, exibir os serviços na listBox por ordem alfabética usando o LINQ
                    List<Servico> servicosOrdenados = funcionarioSelecionado.Servicos.OrderBy(s => s.Descricao).ToList();

                    listBoxServicos.DataSource = servicosOrdenados;
                    listBoxServicos.DisplayMember = "Descricao";
                }
                else
                {
                    // Se não tiver, exibir uma mensagem a indicar que não há serviços associados
                    listBoxServicos.DataSource = new List<string> { "Este funcionário não tem serviços associados" };
                }
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário CriarFuncionario
            CriarFuncionario criarFuncionario = new CriarFuncionario(Funcionarios);

            // Exibir o formulário
            criarFuncionario.ShowDialog();

            // Actualizar a lista de funcionários
            InitLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obter o funcionário selecionado no listBox
            Funcionario funcionarioAEditar = (Funcionario)listBoxFuncionarios.SelectedItem;

            Funcionario editado = null;

            // Verificar se um funcionário foi selecionado
            if (funcionarioAEditar != null)
            {
                // Procurar o funcionário na lista de funcionários
                foreach (Funcionario funcionario in Funcionarios)
                {
                    if (funcionarioAEditar.Id == funcionario.Id)
                    {
                        // Se encontrar, atribuir o funcionário à variável editado
                        editado = funcionario;
                    }
                }

                // Cria uma nova instância do formulário EditarFuncionario
                EditarFuncionario editarFuncionario = new EditarFuncionario(editado);

                // Exibir o formulário
                editarFuncionario.ShowDialog();

                // Actualizar a lista de funcionários
                InitLista();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se a textBox está vazia
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira um nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obter o nome da textBox e converter para minúsculas para não ser case sensitive
            string nome = txtNome.Text.ToLower();

            // Procurar os funcionários cujo nome completo contém o nome especificado usando o LINQ
            // Converter o nome completo para minúsculas antes de fazer a comparação para não ser case sensitive
            List<Funcionario> funcionarios = Funcionarios.Where(f => f.NomeCompleto.ToLower().Contains(nome)).ToList();

            // Verificar se algum funcionário foi encontrado
            if (funcionarios.Count == 0)
            {
                MessageBox.Show("Nenhum funcionário encontrado com o nome indicado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Atualizar a listBoxFuncionarios para mostrar apenas os funcionários encontrados
            listBoxFuncionarios.DataSource = null;
            listBoxFuncionarios.DataSource = funcionarios;
            listBoxFuncionarios.DisplayMember = "NomeCompleto";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a textBox
            txtNome.Text = "";

            // Atualizar a listBoxFuncionarios para mostrar todos os funcionários
            InitLista();
        }
    }
}
