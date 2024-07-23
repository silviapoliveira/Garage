namespace Biblioteca
{
    public class Fatura : IPagamento
    {
        #region Propriedades

        public int Numero { get; set; } // Número da fatura
        public DateTime Data { get; set; } // Data da fatura
        public Marcacao Marcacao { get; set; } // Marcação associada à fatura
        public Dictionary<Servico, double> Precos { get; set; } // preços dos serviços armazenados no dicionário
        public Dictionary<Servico, double> Taxas { get; set; } // taxas dos serviços armazenados no dicionário

        #endregion

        #region Métodos

        public Fatura(int numero, DateTime data, Marcacao marcacao, Dictionary<Servico, double> precos, Dictionary<Servico, double> taxas)
        {
            // Verificar se a marcação foi fornecida
            if (marcacao == null)
            {
                throw new ArgumentException("Uma marcação deve ser selecionada.");
            }

            // Atribuir os parâmetros às propriedades correspondentes
            Numero = numero;
            Data = data;
            Marcacao = marcacao;
            Precos = precos;
            Taxas = taxas;
        }

        // Método para calcular o valor a pagar
        public double ValorAPagar()
        {
            // Calcular o somatório do valor de cada serviço
            double total = 0;
            foreach (var servico in Marcacao.Servicos)
            {
                double preco = Precos[servico];
                double taxa = Taxas[servico];
                total += preco * (1 + taxa / 100);
            }

            // Aplicar um desconto de 5% se houver mais do que um serviço na marcação
            if (Marcacao.Servicos.Count > 1)
            {
                total *= 0.95;
            }

            return total;
        }

        // Sobrescreve o método ToString para retornar uma representação em string da fatura
        public override string ToString()
        {
            return $"Fatura nº {Numero} - {Data.ToString("dd/MM/yyyy")}";
        }

        #endregion
    }
}
