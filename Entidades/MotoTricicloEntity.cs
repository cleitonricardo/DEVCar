using Enums;
using Banco.Db;
using Servicos;

namespace Entidades
{
    public class MotoTricicloEntity : Veiculos
    {
        
        public override void Cadastro(){

             try
            {
                MotosTriciclo moto = new();
                moto.NumeroChassis = 1;
                moto.Tipo=TipoVeiculo.MotosTriciclo;
                Console.WriteLine($"O numero do Chassis será: {NumeroChassis}");
                Console.Write("\nEntre com a data de fabricação :");
                moto.DataFabricacao = Console.ReadLine();
                Console.Write("\nEntre com o Nome :");
                moto.Nome = Console.ReadLine();
                CompradorServicos.ValidaString(moto.Nome);
                Console.Write("\nEntre com a Placa:");
                moto.Placa = Console.ReadLine();
                CompradorServicos.ValidaString(moto.Placa);
                moto.CPF = "00000000000";
                Console.Write("\nEntre com a cor:");
                moto.Cor = Console.ReadLine();
                CompradorServicos.ValidaString(moto.Cor);
                Console.Write("\nInforme a quantidade de Rodas:");
                moto.Rodas = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nInforme a Potencia:");
                moto.Potencia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nveiculo {moto.Nome} cadastrado com sucesso!",
                   Console.ForegroundColor = ConsoleColor.Green);
                Console.ReadLine();

                Banco.Db.BancoDeDados.Veiculos.Add(moto);
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