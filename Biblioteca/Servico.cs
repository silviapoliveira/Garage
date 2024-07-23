namespace Biblioteca
{
    public class Servico : IPagamento
    {
        #region Atributos

        private static int _ultimoId = 0; // variável para manter o controlo do último ID atribuído

        #endregion

        #region Propriedades

        public int Id { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public double Taxa { get; set; }
        
        // Propriedade que representa o funcionário atribuído ao serviço
        public Funcionario FuncionarioAtribuido { get; set; }

        #endregion

        #region Métodos

        public Servico()
        {
            Id = ++_ultimoId; // atribuir o próximo ID disponível ao serviço
        }

        // Método que retorna o próximo ID que será atribuído
        public static int ProximoId()
        {
            return _ultimoId + 1;
        }

        // Método para calcular o valor do serviço
        public double ValorAPagar()
        {
            return Preco * (1 + (Taxa * 0.01));
        }

        public override string ToString()
        {
            return $"{Descricao}";
        }

        #endregion
    }
}
