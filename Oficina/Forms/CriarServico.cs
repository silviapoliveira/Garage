using Biblioteca;

namespace Oficina.Forms
{
    public partial class CriarServico : Form
    {
        #region Variáveis

        List<Servico> Servicos; // lista de todos os serviços
        List<Funcionario> Funcionarios; // lista de todos os funcionários

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário CriarServico, preencher automaticamente o ID do próximo serviço e configurar os campos do formulário.
        /// </summary>
        /// <param name="servicos">A lista de serviços existentes.</param>
        /// <param name="funcionarios">A lista de funcionários existentes.</param>
        public CriarServico(List<Servico> servicos, List<Funcionario> funcionarios)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Servicos = servicos;
            Funcionarios = funcionarios;

            InitializeComponent();

            // Preencher automaticamente o ID do próximo serviço
            lblId.Text = Servico.ProximoId().ToString();

            // Ordenar a lista de funcionários por nome
            Funcionarios = funcionarios.OrderBy(f => f.NomeFuncao).ToList();

            // Configurar o ComboBox dos funcionários
            comboBoxFuncionarios.DataSource = Funcionarios;
            comboBoxFuncionarios.DisplayMember = "NomeFuncao";
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

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar os dados do novo serviço?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, criar um novo serviço com os dados inseridos
                Servico novoServico = new Servico
                {
                    Descricao = txtDescricao.Text,
                    Preco = 0,  // O preço será definido quando for emitida a fatura
                    Taxa = 0    // A taxa será definida quando for emitida a fatura
                };

                // Adicionar o novo serviço à lista de serviço do funcionário selecionado
                Funcionario funcionarioSelecionado = (Funcionario)comboBoxFuncionarios.SelectedItem;
                funcionarioSelecionado.Servicos.Add(novoServico);

                // Definir o funcionário do novo serviço
                novoServico.FuncionarioAtribuido = funcionarioSelecionado;

                // Adicionar o novo serviço à lista de serviços
                Servicos.Add(novoServico);

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
