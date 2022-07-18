using Enums;
using Servicos;
using Banco.Db;

namespace Entidades
{
    public class CarroEntity : Veiculos
    {
        
        public override void Cadastro(){
            Random numAleatorio = new Random();
           int valorInteiro = numAleatorio.Next();
            try{
            Carros carro = new();
            carro.NumeroChassis = valorInteiro;
            carro.Tipo=TipoVeiculo.Carro;
            Console.WriteLine($"O numero do Chassis será: {carro.NumeroChassis}");
            Console.Write("\nEntre com a data de fabricação :");
            carro.DataFabricacao = Console.ReadLine();
            Console.Write("\nEntre com o Nome :");
            carro.Nome = Console.ReadLine();
            CompradorServicos.ValidaString(carro.Nome);
            Console.Write("\nEntre com a Placa:");
            carro.Placa = Console.ReadLine();
            CompradorServicos.ValidaString(carro.Placa);
            carro.CPF = "00000000000";
            Console.Write("\nEntre com a cor:");
            carro.Cor = Console.ReadLine();
            CompradorServicos.ValidaString(carro.Cor);
            Console.Write("\nInforme o Valor: R$");
            carro.Valor = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme a quantidade de Portas:");
            carro.Portas= Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o tipo de Combustivel:");
            carro.Combustivel = Console.ReadLine();
            Console.Write("\nInforme a Potencia:");
            carro.Potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nveiculo {carro.Nome} cadastrado com sucesso!",
               Console.ForegroundColor = ConsoleColor.Green);
            Console.ReadLine();

            Banco.Db.BancoDeDados.Carros.Add(carro);
            }catch(FormatException)
            {
                Console.WriteLine("\nFormato não aceito. Tente novamente",
                Console.ForegroundColor = ConsoleColor.Red);
            }
            catch(Exception error)
            {
                Console.WriteLine($"{error.Message}",
                   Console.ForegroundColor = ConsoleColor.Red);
                Console.Read();
            }
        }
        public override void ListarInformacoes()
        {
            if (BancoDeDados.Carros.Count > 0)
            {
                Console.WriteLine("-----------------------------------------------------------\nLista de Carros");
                foreach (var carro in BancoDeDados.Carros)
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {carro.Nome} - Numero Chassis: {carro.NumeroChassis} - Data de Fabricação: {carro.DataFabricacao}" +
                                     $"\nPlaca: {carro.Placa} - Cor: {carro.Cor} - Valor de Compra: R${carro.Valor} " +
                                     $"\nNumero de Portas: {carro.Portas} - Potencia: {carro.Potencia} - Tipo de Combustivel: {carro.Combustivel}",
                                     Console.ForegroundColor = ConsoleColor.Magenta);
            }
        }
        public override void AletrarInformacoes(string? veiculoEscolhido)
        {
            for (int i = 0; i < BancoDeDados.Carros.Count; i++)
            {
                if (BancoDeDados.Carros[i].Nome == veiculoEscolhido)
                {
                    try
                    {
                        Console.Write($"Está é a cor atual do Veiculo {BancoDeDados.Carros[i].Cor}. \nEntre com a nova cor do veiculo:");
                        string? cor = Console.ReadLine();
                        CompradorServicos.ValidaString(cor);
                        BancoDeDados.Carros[i].Cor = cor;
                        Console.Write($"Está é o valor atual do Veiculo R${BancoDeDados.Carros[i].Valor}. \nEntre com o novo valor do veiculo: R$");
                        string? valor = Console.ReadLine();
                        CompradorServicos.ValidaString(valor);
                        BancoDeDados.Carros[i].Valor =Convert.ToInt32(valor);
                        Console.WriteLine($"\nveiculo atualizado com sucesso!",
               Console.ForegroundColor = ConsoleColor.Green);
                    }
                    catch (FormatException)
                    {

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message,
                                Console.ForegroundColor = ConsoleColor.Red);
                        Console.Read();
                    }
                }
            }
        }
        public override void VenderVeiculo(string? veiculoEscolhido)
        {
            for (int i = 0; i < BancoDeDados.Carros.Count; i++)
            {

                if (BancoDeDados.Carros[i].Nome == veiculoEscolhido)
                {
                    try
                    {
                        Console.Write($"Entre com o CPF do comprador do veiculo: ");
                        string? CPF = Console.ReadLine();
                        CompradorServicos.ValidaCPF(CPF);

                        BancoDeDados.Carros[i].CPF = CPF;
                        Console.WriteLine($"\nveiculo de {veiculoEscolhido} vendido com sucesso! para o CPF : {CPF}",
                        Console.ForegroundColor = ConsoleColor.Blue);
                    }
                    catch (FormatException)
                    {

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message,
                                Console.ForegroundColor = ConsoleColor.Red);
                        Console.Read();
                    }
                }
            }

        }
        public void VeiculosDisponiveis()
        {
            Console.WriteLine("\nLista de carros disponiveis:", Console.ForegroundColor = ConsoleColor.White);
            foreach (var carro in BancoDeDados.Carros)
            {
                if (carro.CPF == "00000000000")
                {
                    
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {carro.Nome} - Numero Chassis: {carro.NumeroChassis} - Data de Fabricação: {carro.DataFabricacao}" +
                                     $"\nPlaca: {carro.Placa} - Cor: {carro.Cor} - Valor de Compra: R${carro.Valor} " +
                                     $"\nNumero de Portas: {carro.Portas} - Potencia: {carro.Potencia} - Tipo de Combustivel: {carro.Combustivel}",
                                     Console.ForegroundColor = ConsoleColor.Magenta);
                }
            }
        }
        public void VeiculosVendidos()
        {
            Console.WriteLine("\nLista de carro vendidos:", Console.ForegroundColor = ConsoleColor.White);
            foreach (var carro in BancoDeDados.Carros)
            {
                if (carro.CPF != "00000000000")
                {
                    
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {carro.Nome} - Numero Chassis: {carro.NumeroChassis} - Data de Fabricação: {carro.DataFabricacao}" +
                                     $"\nPlaca: {carro.Placa} - Cor: {carro.Cor} - Valor de Compra: R${carro.Valor} - Numero de Portas: {carro.Portas} " +
                                     $"\nPotencia: {carro.Potencia} - Tipo de Combustivel: {carro.Combustivel} - CPF do Comprador: {carro.CPF}",
                                     Console.ForegroundColor = ConsoleColor.Magenta);
                }
            }
        }
    }
        }
