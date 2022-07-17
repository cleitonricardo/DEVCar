using Enums;
using Servicos;

namespace Entidades
{
    public class CamioneteEntity : Veiculos
    {
       public override void Cadastro()
       {
        try{
        Camionete camionete = new();
            camionete.NumeroChassis = 1;
            camionete.Tipo=TipoVeiculo.Camionete;
            Console.WriteLine($"O numero do Chassis será: {NumeroChassis}");
            Console.Write("\nEntre com a data de fabricação :");
            camionete.DataFabricacao = Console.ReadLine();
            Console.Write("\nEntre com o Nome :");
            camionete.Nome = Console.ReadLine();
            CompradorServicos.ValidaString(camionete.Nome);
            Console.Write("\nEntre com a Placa:");
            camionete.Placa = Console.ReadLine();
            CompradorServicos.ValidaString(camionete.Placa);
            camionete.CPF = "00000000000";
            Console.Write("\nEntre com a cor:");
            camionete.Cor = Console.ReadLine();
            CompradorServicos.ValidaString(camionete.Cor);
            Console.Write("\nInforme a quantidade de Portas:");
            camionete.Portas = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o tipo de Combustivel:");
            camionete.Combustivel = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme a Potencia:");
            camionete.Potencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme a Cacamba:");
            camionete.Cacamba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nveiculo {camionete.Nome} cadastrado com sucesso!",
               Console.ForegroundColor = ConsoleColor.Green);
            Console.ReadLine();

                Banco.Db.BancoDeDados.Veiculos.Add(camionete);
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