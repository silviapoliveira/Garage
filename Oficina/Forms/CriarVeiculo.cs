using Biblioteca;
using System.Text.RegularExpressions;

namespace Oficina.Forms
{
    public partial class CriarVeiculo : Form
    {
        #region Variáveis

        List<Veiculo> Veiculos; // lista de todos os veículos
        List<Cliente> Clientes; // lista de todos os clientes

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário CriarVeiculo, preencher automaticamente o ID do próximo veículo e configurar os campos do formulário.
        /// </summary>
        /// <param name="veiculos">A lista de veículos existentes.</param>
        /// <param name="clientes">A lista de clientes existentes.</param>
        public CriarVeiculo(List<Veiculo> veiculos, List<Cliente> clientes)
        {
            // Atribuir os parâmetros às variáveis correspondentes
            Veiculos = veiculos;
            Clientes = clientes;

            InitializeComponent();

            // Preencher automaticamente o ID do próximo veículo
            lblId.Text = Veiculo.ProximoId().ToString();

            // Preencher o ComboBox do ano com os anos (do ano atual até 1886, ano do primeiro automóvel)
            for (int ano = DateTime.Now.Year; ano >= 1886; ano--)
            {
                comboBoxAno.Items.Add(ano);
            }

            // Preencher o ComboBox do mês com os meses do ano
            for (int mes = 1; mes <= 12; mes++)
            {
                comboBoxMes.Items.Add(mes);
            }

            // Ordenar a lista de funcionários por nome
            Clientes = clientes.OrderBy(f => f.NomeCompleto).ToList();

            // Configurar o ComboBox dos clientes
            comboBoxClientes.DataSource = Clientes;
            comboBoxClientes.DisplayMember = "NomeCompleto";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se a matrícula tem o formato correto
            if ((!Regex.IsMatch(txtMatricula.Text, @"^\w\w-\w\w-\w\w$")))
            {
                MessageBox.Show("Verifique os dados introduzidos. A matrícula deve ter o formato XX-XX-XX.", "Dados inválidos");
                return;
            }

            // Verificar se um proprietário foi selecionado
            if (comboBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um proprietário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar os dados do novo veículo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, criar um novo veículo com os dados inseridos
                Veiculo novoVeiculo = new Veiculo
                {
                    Tipo = txtTipo.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Matricula = txtMatricula.Text,
                    Ano = (int)comboBoxAno.SelectedItem,
                    Mes = (int)comboBoxMes.SelectedItem
                };

                // Adicionar o novo veículo à lista de veículos do proprietário selecionado
                Cliente clienteSelecionado = (Cliente)comboBoxClientes.SelectedItem;
                clienteSelecionado.Veiculos.Add(novoVeiculo);

                // Definir o proprietário do novo veículo
                novoVeiculo.Proprietario = clienteSelecionado;

                // Adicionar o novo veículo à lista de veículos
                Veiculos.Add(novoVeiculo);

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

        private void comboBoxAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarComboBoxMes();
        }

        /// <summary>
        /// Atualizar os itens do ComboBox do mês com base no ano selecionado.
        /// Se o ano selecionado for o ano atual, limitar os meses à data atual.
        /// Se o ano selecionado não for o ano atual, permitir todos os meses.
        /// </summary>
        private void AtualizarComboBoxMes()
        {
            if (comboBoxAno.SelectedItem != null && (int)comboBoxAno.SelectedItem == DateTime.Now.Year)
            {
                // Se o ano seleccionado for o ano actual, limitar os meses à data atual
                comboBoxMes.Items.Clear();
                for (int mes = 1; mes <= DateTime.Now.Month; mes++)
                {
                    comboBoxMes.Items.Add(mes);
                }
            }
            else
            {
                // Se o ano seleccionado não for o ano actual, permitir todos os meses
                comboBoxMes.Items.Clear();
                for (int mes = 1; mes <= 12; mes++)
                {
                    comboBoxMes.Items.Add(mes);
                }
            }
        }
    }
}
