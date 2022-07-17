using Enums;
using Servicos;

namespace Entidades
{
    public class CarroEntity : Veiculos
    {
        
        public override void Cadastro(){
            try{
            Carros carro = new();
            carro.NumeroChassis = 1;
            carro.Tipo=TipoVeiculo.Carro;
            Console.WriteLine($"O numero do Chassis será: {NumeroChassis}");
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
            Console.Write("\nInforme a quantidade de Portas:");
            carro.Portas= Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o tipo de Combustivel:");
            carro.Combustivel = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme a Potencia:");
            carro.Potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nveiculo {carro.Nome} cadastrado com sucesso!",
               Console.ForegroundColor = ConsoleColor.Green);
            Console.ReadLine();

            Banco.Db.BancoDeDados.Veiculos.Add(carro);
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
        }
        }
