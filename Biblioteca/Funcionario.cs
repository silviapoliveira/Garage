namespace Biblioteca
{
    public class Funcionario
    {

        #region Atributos

        private static int _ultimoId = 0; // variável para manter o controlo do último ID atribuído

        #endregion

        #region Propriedades

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Funcao { get; set; }

        public double Salario { get; set; }

        public List<Servico> Servicos { get; set; } // lista de serviços associados ao funcionário

        // Propriedade que retorna o nome completo do funcionário
        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Apelido}";
            }
        }

        // Propriedade que retorna o nome completo do funcionário e a função
        public string NomeFuncao
        {
            get
            {
                return $"{Nome} {Apelido} - {Funcao}";
            }
        }

        #endregion

        #region Métodos

        public Funcionario()
        {
            Id = ++_ultimoId; // atribuir o próximo ID disponível ao funcionário

            Servicos = new List<Servico>(); // inicializar a lista de serviços
        }

        // Método que retorna o próximo ID que será atribuído
        public static int ProximoId()
        {
            return _ultimoId + 1;
        }

        // Sobrescreve o método ToString para retornar uma representação em string do funcionário
        public override string ToString()
        {
            return $"{Id} - {Nome} {Apelido}";
        }

        #endregion
    }
}
