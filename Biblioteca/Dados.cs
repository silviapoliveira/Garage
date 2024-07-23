namespace Biblioteca
{
    public class Dados
    {
        #region Propriedades
        public List<Cliente> Clientes { get; set; } // lista para armazenar os dados dos clientes

        public List<Veiculo> Veiculos { get; set; } // lista para armazenar os dados dos veículos

        public List<Funcionario> Funcionarios { get; set; } // lista para armazenar os dados dos funcionários

        public List<Servico> Servicos { get; set; } // lista para armazenar os dados dos serviços

        public List<Marcacao> Marcacoes { get; set; } // lista para armazenar os dados das marcações

        public List<Fatura> Faturas { get; set; } // lista para armazenar os dados das faturas

        #endregion

        #region Métodos

        public Dados()
        {
            // Inicializar as listas
            Clientes = new List<Cliente>();
            Veiculos = new List<Veiculo>();
            Funcionarios = new List<Funcionario>();
            Servicos = new List<Servico>();
            Marcacoes = new List<Marcacao>();
            Faturas = new List<Fatura>();
        }

        // Método para guardar os dados dos clientes num arquivo
        public void GuardarClientes(List<Cliente> clientes)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"clientes.txt"))
                {
                    foreach (Cliente cliente in clientes)
                    {
                        // Escrever os dados do cliente no arquivo
                        // LINQ usado para seleccionar os ID's dos veículos
                        writer.WriteLine($"{cliente.Id};{cliente.Nome};{cliente.Apelido};{cliente.Morada};{cliente.Telemovel};{cliente.Email};{cliente.Nif};{string.Join(",", cliente.Veiculos.Select(v => v.Id))}");
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro se ocorrer um problema ao tentar guardar os dados
                Console.WriteLine($"Ocorreu um erro ao tentar guardar os clientes: {ex.Message}");
            }
        }

        // Método para carregar os dados dos clientes de um arquivo
        public List<Cliente> CarregarClientes()
        {
            if (!File.Exists(@"clientes.txt"))
            {
                return new List<Cliente>(); // retornar uma lista vazia se o arquivo não existir
            }

            using (StreamReader reader = new StreamReader(@"clientes.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');
                    Cliente cliente = new Cliente
                    {
                        Id = int.Parse(partes[0]),
                        Nome = partes[1],
                        Apelido = partes[2],
                        Morada = partes[3],
                        Telemovel = partes[4],
                        Email = partes[5],
                        Nif = partes[6]
                    };
                    // Adicionar o cliente à lista
                    Clientes.Add(cliente);
                }
                reader.Close();
            }
            // Retornar a lista de clientes
            return Clientes;
        }

        // Método para guardar os dados dos veículos num arquivo
        public void GuardarVeiculos(List<Veiculo> veiculos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"veiculos.txt"))
                {
                    foreach (Veiculo veiculo in veiculos)
                    {
                        // Escrever os dados do veículo no arquivo
                        writer.WriteLine($"{veiculo.Id};{veiculo.Tipo};{veiculo.Marca};{veiculo.Modelo};{veiculo.Matricula};{veiculo.Ano};{veiculo.Mes};{veiculo.Proprietario?.Id}");
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro se ocorrer um problema ao tentar guardar os dados
                Console.WriteLine($"Ocorreu um erro ao tentar guardar os veículos: {ex.Message}");
            }
        }

        // Método para carregar os dados dos veículos de um arquivo
        public List<Veiculo> CarregarVeiculos()
        {
            if (!File.Exists(@"veiculos.txt"))
            {
                return new List<Veiculo>(); // retornar uma lista vazia se o arquivo não existir
            }

            using (StreamReader reader = new StreamReader(@"veiculos.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');
                    Veiculo veiculo = new Veiculo
                    {
                        Id = int.Parse(partes[0]),
                        Tipo = partes[1],
                        Marca = partes[2],
                        Modelo = partes[3],
                        Matricula = partes[4],
                        Ano = int.Parse(partes[5]),
                        Mes = int.Parse(partes[6]),
                        Proprietario = int.TryParse(partes[7], out int proprietarioId)
                            // LINQ usado aqui para encontrar o proprietário pelo ID
                            ? Clientes.FirstOrDefault(c => c.Id == proprietarioId)
                            : null
                    };
                    // Adicionar o veículo à lista
                    Veiculos.Add(veiculo);

                    // Adicionar o veículo à lista de veículos do proprietário
                    veiculo.Proprietario?.Veiculos.Add(veiculo);
                }
                reader.Close();
            }
            // Retornar a lista de veículos
            return Veiculos;
        }

        // Método para guardar os dados dos funcionários num arquivo
        public void GuardarFuncionarios(List<Funcionario> funcionarios)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"funcionarios.txt"))
                {
                    foreach (Funcionario funcionario in funcionarios)
                    {
                        // Escrever os dados do funcionário no arquivo
                        // LINQ usado aqui para selecionar os ID's dos serviços
                        writer.WriteLine($"{funcionario.Id};{funcionario.Nome};{funcionario.Apelido};{funcionario.Funcao};{funcionario.Salario};{string.Join(",", funcionario.Servicos.Select(s => s.Id))}");
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro se ocorrer um problema ao tentar guardar os dados
                Console.WriteLine($"Ocorreu um erro ao tentar guardar os funcionários: {ex.Message}");
            }
        }

        // Método para carregar os dados dos funcionários de um arquivo
        public List<Funcionario> CarregarFuncionarios()
        {
            if (!File.Exists(@"funcionarios.txt"))
            {
                return new List<Funcionario>(); // retornar uma lista vazia se o arquivo não existir
            }

            using (StreamReader reader = new StreamReader(@"funcionarios.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');
                    Funcionario funcionario = new Funcionario
                    {
                        Id = int.Parse(partes[0]),
                        Nome = partes[1],
                        Apelido = partes[2],
                        Funcao = partes[3],
                        Salario = double.Parse(partes[4])
                    };
                    // Adicionar o funcionário à lista
                    Funcionarios.Add(funcionario);
                }
                reader.Close();
            }
            // Retornar a lista de funcionários
            return Funcionarios;
        }


        // Método para guardar os dados dos serviços num arquivo
        public void GuardarServicos(List<Servico> servicos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"servicos.txt"))
                {
                    foreach (Servico servico in servicos)
                    {
                        // Escrever os dados do serviço no arquivo
                        writer.WriteLine($"{servico.Id};{servico.Descricao};{servico.Preco};{servico.Taxa};{servico.FuncionarioAtribuido?.Id}");
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro se ocorrer um problema ao tentar guardar os dados
                Console.WriteLine($"Ocorreu um erro ao tentar guardar os serviços: {ex.Message}");
            }
        }

        // Método para carregar os dados dos serviços de um arquivo
        public List<Servico> CarregarServicos()
        {
            if (!File.Exists(@"servicos.txt"))
            {
                return new List<Servico>(); // retornar uma lista vazia se o arquivo não existir
            }

            using (StreamReader reader = new StreamReader(@"servicos.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');
                    Servico servico = new Servico
                    {
                        Id = int.Parse(partes[0]),
                        Descricao = partes[1],
                        Preco = double.Parse(partes[2]),
                        Taxa = double.Parse(partes[3]),
                        FuncionarioAtribuido = int.TryParse(partes[4], out int funcionarioId)
                            // LINQ usado aqui para encontrar o funcionário pelo ID
                            ? Funcionarios.FirstOrDefault(f => f.Id == funcionarioId)
                            : null
                    };
                    // Adicionar o serviço à lista
                    Servicos.Add(servico);

                    // Adicionar o serviço à lista de serviços do funcionário
                    servico.FuncionarioAtribuido?.Servicos.Add(servico);
                }
                reader.Close();
            }
            // Retornar a lista de serviços
            return Servicos;
        }

        // Método para guardar os dados das marcações num arquivo
        public void GuardarMarcacoes(List<Marcacao> marcacoes)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"marcacoes.txt"))
                {
                    foreach (Marcacao marcacao in marcacoes)
                    {
                        // Escrever os dados da marcação no arquivo
                        writer.WriteLine($"{marcacao.Id};{marcacao.Cliente.Id};{marcacao.Veiculo.Id};{string.Join(",", marcacao.Servicos.Select(s => s.Id))};{marcacao.Data}");
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro se ocorrer um problema ao tentar guardar os dados
                Console.WriteLine($"Ocorreu um erro ao tentar guardar as marcações: {ex.Message}");
            }
        }

        // Método para carregar os dados das marcações de um arquivo
        public List<Marcacao> CarregarMarcacoes()
        {
            if (!File.Exists(@"marcacoes.txt"))
            {
                return new List<Marcacao>(); // retornar uma lista vazia se o arquivo não existir
            }

            using (StreamReader reader = new StreamReader(@"marcacoes.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');
                    Marcacao marcacao = new Marcacao
                    {
                        // Definir o Id da marcação
                        Id = int.Parse(partes[0]),
                        // LINQ usado aqui para encontrar o cliente pelo ID
                        Cliente = Clientes.FirstOrDefault(c => c.Id == int.Parse(partes[1])),
                        // LINQ usado aqui para encontrar o veículo pelo ID
                        Veiculo = Veiculos.FirstOrDefault(v => v.Id == int.Parse(partes[2])),
                        // LINQ usado aqui para encontrar os serviços pelos ID's
                        Servicos = partes[3].Split(',').Select(id => Servicos.FirstOrDefault(s => s.Id == int.Parse(id))).ToList(),
                        Data = DateTime.Parse(partes[4])
                    };
                    // Adicionar a marcação à lista
                    Marcacoes.Add(marcacao);
                }
                reader.Close();
            }

            // Retornar a lista de marcações
            return Marcacoes;
        }

        // Método para guardar os dados das faturas num arquivo
        public void GuardarFaturas(List<Fatura> faturas)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"faturas.txt"))
                {
                    foreach (Fatura fatura in faturas)
                    {
                        // Escrever os dados da fatura no arquivo
                        // LINQ usado aqui para selecionar os ID's dos serviços, preços e taxas
                        string servicosPrecosTaxas = string.Join(",", fatura.Marcacao.Servicos.Select(s => $"{s.Id}:{fatura.Precos[s]}:{fatura.Taxas[s]}"));
                        writer.WriteLine($"{fatura.Numero};{fatura.Data};{fatura.Marcacao.Id};{servicosPrecosTaxas}");
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro se ocorrer um problema ao tentar guardar os dados
                Console.WriteLine($"Ocorreu um erro ao tentar guardar as faturas: {ex.Message}");
            }
        }

        // Método para carregar os dados das faturas de um arquivo
        public List<Fatura> CarregarFaturas()
        {
            if (!File.Exists(@"faturas.txt"))
            {
                return new List<Fatura>(); // retornar uma lista vazia se o arquivo não existir
            }

            using (StreamReader reader = new StreamReader(@"faturas.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');
                    // Criar novos dicionários para preços e taxas
                    Dictionary<Servico, double> precos = new Dictionary<Servico, double>();
                    Dictionary<Servico, double> taxas = new Dictionary<Servico, double>();
                    // LINQ usado aqui para encontrar os serviços pelos ID's e preencher os dicionários de preços e taxas
                    foreach (var str in partes[3].Split(','))
                    {
                        string[] subPartes = str.Split(':');
                        Servico servico = Servicos.FirstOrDefault(s => s.Id == int.Parse(subPartes[0]));
                        precos[servico] = double.Parse(subPartes[1]);
                        taxas[servico] = double.Parse(subPartes[2]);
                    }
                    Fatura fatura = new Fatura(
                        int.Parse(partes[0]),
                        DateTime.Parse(partes[1]),
                        // LINQ usado aqui para encontrar a marcação pelo ID
                        Marcacoes.FirstOrDefault(m => m.Id == int.Parse(partes[2])),
                        precos,
                        taxas
                    );
                    // Adicionar a fatura à lista
                    Faturas.Add(fatura);
                }
                reader.Close();
            }
            // Retornar a lista de faturas
            return Faturas;
        }

        #endregion
    }
}
