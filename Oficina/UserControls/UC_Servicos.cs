using Biblioteca;
using Oficina.Forms;

namespace Oficina.UserControls
{
    public partial class UC_Servicos : UserControl
    {
        #region Propriedades

        public List<Servico> Servicos { get; set; } // lista de todos os servicos
        public List<Funcionario> Funcionarios { get; set; } // lista de todos os funcionários

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do User Control UC_Servicos e inicializar a lista de serviços.
        /// </summary>
        /// <param name="servicos">A lista de serviços existentes.</param>
        /// <param name="funcionarios">A lista de funcionários existentes.</param>
        public UC_Servicos(List<Servico> servicos, List<Funcionario> funcionarios)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Servicos = servicos;
            Funcionarios = funcionarios;

            InitializeComponent();

            // Inicializar a lista de clientes
            InitLista();
        }

        // Método para inicializar a lista de serviços
        public void InitLista()
        {
            // Limpar o interface e permitir atualizar a lista
            listBoxServicos.DataSource = null;

            // Ordenar a lista de serviços por descrição usando o LINQ
            List<Servico> servicosOrdenados = Servicos.OrderBy(s => s.Descricao).ToList();

            // Atribuir a lista ordenada de serviços ao DataSource do listBox
            listBoxServicos.DataSource = servicosOrdenados;

            // Definir a propriedade que será exibida no listBox
            listBoxServicos.DisplayMember = "Descricao";
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se um serviço está selecionado
            if (listBoxServicos.SelectedItem is Servico servicoSelecionado)
            {
                // Atualizar as labels com os dados do veículo
                lblDescricao.Text = servicoSelecionado.Descricao;

                // Verificar se o serviço tem um funcionário associado
                if (servicoSelecionado.FuncionarioAtribuido != null)
                {
                    // Se tiver, exibir o nome do proprietário
                    lblFuncionario.Text = servicoSelecionado.FuncionarioAtribuido.NomeCompleto;
                }
                else
                {
                    // Se não tiver, exibir uma mensagem indicando que não há funcionário associado
                    lblFuncionario.Text = "Nenhum funcionário associado";
                }
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do formulário CriarServico
            CriarServico criarServico = new CriarServico(Servicos, Funcionarios);

            // Exibir o formulário
            criarServico.ShowDialog();

            // Actualizar a lista de serviços
            InitLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obter o servico selecionado no listBox
            Servico servicoAEditar = (Servico)listBoxServicos.SelectedItem;

            Servico editado = null;

            // Verificar se um serviço foi selecionado
            if (servicoAEditar != null)
            {
                // Procurar o serviço na lista de serviços
                foreach (Servico servico in Servicos)
                {
                    if (servicoAEditar.Id == servico.Id)
                    {
                        // Se encontrar, atribuir o serviço à variável editado
                        editado = servico;
                    }
                }

                // Criar uma nova instância do formulário EditarServico
                EditarServico editarServico = new EditarServico(editado, Funcionarios);

                // Exibir o formulário
                editarServico.ShowDialog();

                // Actualizar a lista de serviços
                InitLista();
            }
            else
            {
                // Se nenhum serviço for selecionado, exibir uma mensagem de erro
                MessageBox.Show("Selecione um serviço para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obter o serviço selecionado no listBox
            Servico servicoAEliminar = (Servico)listBoxServicos.SelectedItem;

            // Verificar se um serviço foi selecionado
            if (servicoAEliminar == null)
            {
                MessageBox.Show("Selecione um serviço para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja eliminar o serviço selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, eliminar o serviço da lista de serviços
                Servicos.Remove(servicoAEliminar);

                // Se o serviço tiver um funcionário associado, remover o serviço da lista de serviços do funcionário
                if (servicoAEliminar.FuncionarioAtribuido != null)
                {
                    servicoAEliminar.FuncionarioAtribuido.Servicos.Remove(servicoAEliminar);
                }

                // Actualizar a lista de serviços
                InitLista();

                // Limpar labels
                lblDescricao.Text = null;
                lblFuncionario.Text = null;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se a textBox está vazia
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, insira uma descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obter a descrição da textBox e converter para minúsculas para não ser case sensitive
            string descricao = txtDescricao.Text.ToLower();

            // Procurar os serviços cuja descrição contém a descrição indicada usando o LINQ
            // Converter a descrição para minúsculas antes de fazer a comparação para não ser case sensitive
            List<Servico> servicos = Servicos.Where(s => s.Descricao.ToLower().Contains(descricao)).ToList();

            // Verificar se algum serviço foi encontrado
            if (servicos.Count == 0)
            {
                MessageBox.Show("Nenhum serviço encontrado com a descrição indicada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Atualizar a listBoxServicos para mostrar apenas os serviços encontrados
            listBoxServicos.DataSource = null;
            listBoxServicos.DataSource = servicos;
            listBoxServicos.DisplayMember = "Descricao";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a textBox
            txtDescricao.Text = "";

            // Atualizar a listBoxServicos para mostrar todos os serviços
            InitLista();
        }
    }
}
