namespace Biblioteca
{
    public class Cliente
    {

        #region Atributos

        private static int _ultimoId = 0; // variável para manter o controlo do último ID atribuído

        #endregion

        #region Propriedades

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Morada { get; set; }

        public string Telemovel { get; set; }

        public string Email { get; set; }

        public string Nif { get; set; }

        public List<Veiculo> Veiculos { get; set; } // lista de veículos associados ao cliente

        // Propriedade que retorna o nome completo do cliente
        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Apelido}";
            }
        }

        #endregion

        #region Métodos

        public Cliente()
        {
            Id = ++_ultimoId; // atribuir o próximo ID disponível ao cliente

            Veiculos = new List<Veiculo>(); // inicializar a lista de veículos
        }

        // Método que retorna o próximo ID que será atribuído
        public static int ProximoId()
        {
            return _ultimoId + 1;
        }

        // Método para verificar se o número de telemóvel é válido
        public static string TelemovelValido(string telemovel)
        {
            // Verificar se o telemóvel tem 9 dígitos
            if (telemovel.Length != 9 || !telemovel.All(char.IsDigit))
            {
                return "O número de telemóvel deve ter 9 dígitos.";
            }

            return null;
        }

        // Método para verificar se o email é válido
        public static bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                string[] parts = email.Split('@');
                return addr.Address == email && parts[1].Contains(".") && parts[1].LastIndexOf(".") < parts[1].Length - 1;
            }
            catch
            {
                return false;
            }
        }

        // Método para verificar se o NIF é válido
        public static string NifValido(string nif, List<Cliente> clientes)
        {
            // Verificar se o NIF tem 9 dígitos
            if (nif.Length != 9 || !nif.All(char.IsDigit))
            {
                return "O NIF deve ter 9 dígitos.";
            }

            // Verificar se o NIF é único
            if (clientes.Any(c => c.Nif == nif))
            {
                return "Já existe um cliente com esse NIF.";
            }

            return null;
        }

        // Sobrescreve o método ToString para retornar uma representação em string do cliente
        public override string ToString()
        {
            return $"{Nome} {Apelido}";
        }

        #endregion
    }
}
