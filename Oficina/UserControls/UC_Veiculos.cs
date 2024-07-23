using Biblioteca;
using Oficina.Forms;
using System.Text.RegularExpressions;

namespace Oficina.UserControls
{
    public partial class UC_Veiculos : UserControl
    {
        #region Propriedades

        public List<Veiculo> Veiculos { get; set; } // lista de todos os veículos
        public List<Cliente> Clientes { get; set; } // lista de todos os clientes

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do User Control UC_Veiculos e inicializar a lista de veículos.
        /// </summary>
        /// <param name="veiculos">A lista de veículos existentes.</param>
        /// <param name="clientes">A lista de clientes existentes.</param>
        public UC_Veiculos(List<Veiculo> veiculos, List<Cliente> clientes)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Veiculos = veiculos;
            Clientes = clientes;

            InitializeComponent();

            // Inicializar a lista de veículos
            InitLista();
        }

        // Método para inicializar a lista de veículos
        public void InitLista()
        {
            // Limpar o interface e permitir atualizar a lista
            listBoxVeiculos.DataSource = null;

            // Ordenar a lista de veículos por MarcaModeloMatricula usando o LINQ
            List<Veiculo> veiculosOrdenados = Veiculos.OrderBy(v => v.MarcaModelo).ToList();

            // Atribuir a lista ordenada de veículos ao DataSource do listBox
            listBoxVeiculos.DataSource = veiculosOrdenados;

            // Definir a propriedade que será exibida no listBox
            listBoxVeiculos.DisplayMember = "MarcaModeloMatricula";
        }

        // Evento que ocorre quando o item selecionado no listBox muda
        private void listBoxVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se um veículo está selecionado
            if (listBoxVeiculos.SelectedItem is Veiculo veiculoSelecionado)
            {
                // Atualizar as labels com os dados do veículo
                lblVeiculoTipo.Text = veiculoSelecionado.Tipo;
                lblVeiculoMarca.Text = veiculoSelecionado.Marca;
                lblVeiculoModelo.Text = veiculoSelecionado.Modelo;
                lblVeiculoMatricula.Text = veiculoSelecionado.Matricula;
                lblVeiculoAno.Text = veiculoSelecionado.Ano.ToString();
                lblVeiculoMes.Text = veiculoSelecionado.Mes.ToString();

                // Verificar se o veículo tem um proprietário associado
                if (veiculoSelecionado.Proprietario != null)
                {
                    // Se tiver, exibir o nome do proprietário
                    lblProprietario.Text = veiculoSelecionado.Proprietario.NomeCompleto;
                }
                else
                {
                    // Se não tiver, exibir uma mensagem indicando que não há proprietário associado
                    lblProprietario.Text = "Nenhum proprietário associado";
                }
            }
        }

        private void btnCriarVeiculo_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do formulário CriarVeiculo
            CriarVeiculo criarVeiculo = new CriarVeiculo(Veiculos, Clientes);

            // Exibir o formulário
            criarVeiculo.ShowDialog();

            // Actualizar a lista de veículos
            InitLista();
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            // Obter o veículo selecionado no listBox
            Veiculo veiculoAEditar = (Veiculo)listBoxVeiculos.SelectedItem;

            Veiculo editado = null;

            // Verificar se um veículo foi selecionado
            if (veiculoAEditar != null)
            {
                // Procurar o veículo na lista de veículos
                foreach (Veiculo veiculo in Veiculos)
                {
                    if (veiculoAEditar.Id == veiculo.Id)
                    {
                        // Se encontrar, atribuir o veículo à variável editado
                        editado = veiculo;
                    }
                }

                // Criar uma nova instância do formulário EditarVeiculo
                EditarVeiculo editarVeiculo = new EditarVeiculo(editado, Clientes);

                // Exibir o formulário
                editarVeiculo.ShowDialog();

                // Actualizar a lista de veículos
                InitLista();
            }
            else
            {
                // Se nenhum veículo for selecionado, exibir uma mensagem de erro
                MessageBox.Show("Selecione um veículo para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se a textBox está vazia ou se a matrícula não tem o formato correto
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || !Regex.IsMatch(txtMatricula.Text, @"^\w\w-\w\w-\w\w$"))
            {
                MessageBox.Show("Por favor, insira uma matrícula com o formato XX-XX-XX.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obter a matrícula da textBox e converter para minúsculas para não ser case sensitive
            string matricula = txtMatricula.Text.ToLower();

            // Procurar o veículo com a matrícula indicada usando o LINQ
            // Converter a matrícula para minúsculas antes de fazer a comparação para não ser case sensitive
            Veiculo veiculo = Veiculos.SingleOrDefault(v => v.Matricula.ToLower() == matricula);

            // Verificar se o veículo foi encontrado
            if (veiculo == null)
            {
                MessageBox.Show("Nenhum veículo encontrado com a matrícula indicada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Atualizar a listBoxVeiculos para mostrar apenas o veículo encontrado
            listBoxVeiculos.DataSource = null;
            listBoxVeiculos.DataSource = new List<Veiculo> { veiculo };
            listBoxVeiculos.DisplayMember = "MarcaModeloMatricula";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a textBox
            txtMatricula.Text = "";

            // Atualizar a listBoxVeiculos para mostrar todos os veículos
            InitLista();
        }
    }
}
