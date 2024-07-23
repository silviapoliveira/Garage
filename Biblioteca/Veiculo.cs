using System.Text.RegularExpressions;

namespace Biblioteca
{
    public class Veiculo
    {
        #region Atributos

        private static int _ultimoId = 0; // variável para manter o controlo do último ID atribuído

        private string _matricula; // variável para armazenar a matrícula do veículo

        #endregion

        #region Propriedades

        public int Id { get; set; }

        public string Tipo { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        // Propriedade da matrícula com validação de formato
        public string Matricula
        {
            get
            {
                return _matricula;
            }

            set
            {
                if (Regex.IsMatch(value, @"^\w\w-\w\w-\w\w$")) // verificar se a matrícula tem o formato XX-XX-XX
                {
                    _matricula = value;
                }
                else
                {
                    // Se a matrícula não tiver o formato correto, lançar uma excepção
                    throw new ArgumentException("Matrícula inválida. O formato deve ser XX-XX-XX.");
                }
            }
        }

        public int Ano { get; set; }

        public int Mes { get; set; }

        // Propriedade que retorna a marca e o modelo do veículo
        public string MarcaModelo
        {
            get
            {
                return $"{Marca} {Modelo}";
            }
        }

        // Propriedade que representa o proprietário do veículo
        public Cliente Proprietario { get; set; }

        #endregion

        #region Métodos

        public Veiculo()
        {
            Id = ++_ultimoId; // atribuir o próximo ID disponível ao veículo
        }

        // Método que retorna o próximo ID que será atribuído
        public static int ProximoId()
        {
            return _ultimoId + 1;
        }

        // Sobrescreve o método ToString para retornar uma representação em string do veículo
        public override string ToString()
        {
            return $"{Marca} {Modelo} {Matricula}";
        }

        #endregion
    }
}
