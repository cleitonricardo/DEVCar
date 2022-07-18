using Enums;
using Servicos;
using Banco.Db;


namespace Entidades
{
    public class CamioneteEntity : Veiculos
    {
       public override void Cadastro()
       {
         Random numAleatorio = new Random();
           int valorInteiro = numAleatorio.Next();
        try{
        Camionete camionete = new();
            camionete.NumeroChassis = valorInteiro;
            camionete.Tipo=TipoVeiculo.Camionete;
            Console.WriteLine($"O numero do Chassis será: {camionete.NumeroChassis}");
            Console.Write("\nEntre com a data de fabricação :");
            camionete.DataFabricacao = Console.ReadLine();
            Console.Write("\nEntre com o Nome :");
            camionete.Nome = Console.ReadLine();
            CompradorServicos.ValidaString(camionete.Nome);
            Console.Write("\nEntre com a Placa:");
            camionete.Placa = Console.ReadLine();
            CompradorServicos.ValidaString(camionete.Placa);
            camionete.CPF = "00000000000";
            camionete.Cor = "Roxo";
            CompradorServicos.ValidaString(camionete.Cor);
            Console.Write("\nInforme o Valor: R$");
            camionete.Valor = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme a quantidade de Portas:");
            camionete.Portas = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o tipo de Combustivel:");
            camionete.Combustivel = Console.ReadLine();
            Console.Write("\nInforme a Potencia:");
            camionete.Potencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme a Cacamba:");
            camionete.Cacamba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nveiculo {camionete.Nome} cadastrado com sucesso!",
               Console.ForegroundColor = ConsoleColor.Green);
            Console.ReadLine();

                Banco.Db.BancoDeDados.Camionete.Add(camionete);
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
            if (BancoDeDados.Camionete.Count > 0)
            {
                Console.WriteLine("-----------------------------------------------------------\nLista de Camionete");
                foreach (var camionete in BancoDeDados.Camionete)
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {camionete.Nome}-Numero Chassis {camionete.NumeroChassis}-Data de Fabricação {camionete.DataFabricacao}" +
                                     $"\nPlaca {camionete.Placa} - Cor {camionete.Cor} - Valor de Compra: R${camionete.Valor}" +
                                     $"\nNumero de Portas {camionete.Portas} - Potencia {camionete.Potencia} - Tipo de Combustivel: {camionete.Combustivel} - Cacamba {camionete.Cacamba}",
                                     Console.ForegroundColor = ConsoleColor.Green);
            }
        }
       public override void AletrarInformacoes(string? veiculoEscolhido)
        {
            for (int i = 0; i < BancoDeDados.Camionete.Count; i++)
            {
                if (BancoDeDados.Camionete[i].Nome == veiculoEscolhido)
                {
                    try
                    {
                        Console.Write($"Está é o valor atual do Veiculo R${BancoDeDados.Camionete[i].Valor}. \nEntre com a novo valor do veiculo: R$");
                        string? valor = Console.ReadLine();
                        CompradorServicos.ValidaString(valor);
                        BancoDeDados.Camionete[i].Valor =Convert.ToInt32(valor);
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
            for (int i = 0; i < BancoDeDados.Camionete.Count; i++)
            {

                if (BancoDeDados.Camionete[i].Nome == veiculoEscolhido)
                {
                    try
                    {
                        Console.Write($"Entre com o CPF do comprador do veiculo: ");
                        string? CPF = Console.ReadLine();
                        CompradorServicos.ValidaCPF(CPF);

                        BancoDeDados.Camionete[i].CPF = CPF;
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
            Console.WriteLine("\nLista de camionete disponiveis:", Console.ForegroundColor = ConsoleColor.White);
            foreach (var camionete in BancoDeDados.Camionete)
            {
                if (camionete.CPF == "00000000000")
                {
                    
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {camionete.Nome}-Numero Chassis {camionete.NumeroChassis}-Data de Fabricação {camionete.DataFabricacao}" +
                                     $"\nPlaca {camionete.Placa} - Cor {camionete.Cor} - Valor de Compra: R${camionete.Valor}" +
                                     $"\nNumero de Portas {camionete.Portas} - Potencia {camionete.Potencia} - Tipo de Combustivel: {camionete.Combustivel} - Cacamba {camionete.Cacamba}",
                                     Console.ForegroundColor = ConsoleColor.Green);
                }
            }
        }
       public void VeiculosVendidos()
        {
            Console.WriteLine("\nLista de camionete vendidos:", Console.ForegroundColor = ConsoleColor.White);
            foreach (var camionete in BancoDeDados.Camionete)
            {
                if (camionete.CPF != "00000000000")
                {
                    
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {camionete.Nome}-Numero Chassis {camionete.NumeroChassis}-Data de Fabricação {camionete.DataFabricacao}" +
                                     $"\nPlaca {camionete.Placa} - Cor {camionete.Cor} - Valor de Compra: R${camionete.Valor} - Numero de Portas {camionete.Portas}" +
                                     $"\n - Potencia {camionete.Potencia} - Tipo de Combustivel: {camionete.Combustivel} - Cacamba {camionete.Cacamba} - CPF do Comprador: {camionete.CPF}",
                                     Console.ForegroundColor = ConsoleColor.Green);
                }
            }
        }
    }
}