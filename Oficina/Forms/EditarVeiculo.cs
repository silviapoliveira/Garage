using Biblioteca;
using System.Text.RegularExpressions;

namespace Oficina.Forms
{
    public partial class EditarVeiculo : Form
    {
        #region Variáveis

        Veiculo _editado; // veículo que está a ser editado
        List<Cliente> Clientes; // lista de todos os clientes

        #endregion

        /// <summary>
        /// Inicializar uma nova instância do formulário EditarVeiculo e preencher os campos do formulário com os dados do veículo que está a ser editado.
        /// </summary>
        /// <param name="editado">O veículo que está a ser editado.</param>
        /// <param name="clientes">A lista de todos os clientes existentes.</param>
        public EditarVeiculo(Veiculo editado, List<Cliente> clientes)
        {
            InitializeComponent();

            // Atribui os parâmetros às variáveis correspondentes
            Clientes = clientes;
            _editado = editado;

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

            // Preencher os campos do formulário com os dados do veículo que está a ser editado
            lblId.Text = editado.Id.ToString();
            txtTipo.Text = editado.Tipo;
            txtMarca.Text = editado.Marca;
            txtModelo.Text = editado.Modelo;
            txtMatricula.Text = editado.Matricula;
            comboBoxAno.SelectedItem = editado.Ano;
            comboBoxMes.SelectedItem = editado.Mes;

            // Ordenar a lista de funcionários por nome
            Clientes = clientes.OrderBy(f => f.NomeCompleto).ToList();

            // Configurar o ComboBox dos clientes
            comboBoxClientes.DataSource = Clientes;
            comboBoxClientes.DisplayMember = "NomeCompleto";
            comboBoxClientes.SelectedItem = editado.Proprietario;
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

            // Remover o veículo da lista de veículo do cliente antigo
            if (_editado.Proprietario != null)
            {
                _editado.Proprietario.Veiculos.Remove(_editado);
            }

            // Mostrar uma mensagem de confirmação
            var resultado = MessageBox.Show("Tem a certeza que deseja guardar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Se o utilizador confirmar, actualizar os dados do veículo
                _editado.Tipo = txtTipo.Text;
                _editado.Marca = txtMarca.Text;
                _editado.Modelo = txtModelo.Text;
                _editado.Matricula = txtMatricula.Text;
                _editado.Ano = (int)comboBoxAno.SelectedItem;
                _editado.Mes = (int)comboBoxMes.SelectedItem;

                // Actualizar o proprietário do veículo
                Cliente novoProprietario = (Cliente)comboBoxClientes.SelectedItem;
                novoProprietario.Veiculos.Add(_editado);
                _editado.Proprietario = novoProprietario;

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
