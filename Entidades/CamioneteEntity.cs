using Enums;

namespace Entidades
{
    public class CamioneteEntity : Veiculos
    {
        public CamioneteEntity(TipoVeiculo tipo)
        {
            Camionete camionete = new();

            

            Console.WriteLine("Informe a quantidade de Portas:");
            camionete.Portas = Console.ReadLine();
            Console.WriteLine("Informe o tipo de Combustivel:");
            camionete.Combustivel = Console.ReadLine();        
            Console.WriteLine("Informe a Potencia:");
            camionete.Potencia = Console.ReadLine();
            Console.WriteLine("Informe o valor da Cacamba em Litros:");
            camionete.Cacamba = Console.ReadLine();
        }
        }
}