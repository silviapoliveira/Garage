namespace Biblioteca
{
    public class Marcacao
    {
        #region Atributos

        private static int _ultimoId = 0; // variável para manter o controlo do último ID atribuído

        #endregion

        #region Propriedades

        public int Id { get; set; } // Id da marcação

        public Cliente Cliente { get; set; } // Cliente associado à marcação

        public Veiculo Veiculo { get; set; } // Veículo associado à marcação

        public List<Servico> Servicos { get; set; } // Lista de serviços associados à marcação

        public DateTime Data { get; set; } // Data e hora da marcação

        // Propriedade que retorna a data e o nome do cliente
        public string DataCliente
        {
            get
            {
                return $"{Data} {Cliente}";
            }
        }

        #endregion

        #region Métodos

        public Marcacao()
        {
            Id = ++_ultimoId; // atribuir o próximo ID disponível à marcação
        }

        // Método que retorna o próximo ID que será atribuído
        public static int ProximoId()
        {
            return _ultimoId + 1;
        }

        // Sobrescreve o método ToString para retornar uma representação em string da marcação
        public override string ToString()
        {
            return $"{Data.ToString("dd/MM/yyyy")} {Cliente} {Veiculo}";
        }

        #endregion
    }
}
