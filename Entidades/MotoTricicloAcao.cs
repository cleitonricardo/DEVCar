using Enums;

namespace Entidades
{
    public class MotoTricicloAcao : Veiculos
    {
        public MotoTricicloAcao(TipoVeiculo tipo)
        {
            MotosTriciclo motoTriciclo = new();
           
                       
            Console.WriteLine("Informe a quantidade de Rodas:");
            motoTriciclo.Rodas = Console.ReadLine();
            Console.WriteLine("Informe a Potencia:");
            motoTriciclo.Potencia = Console.ReadLine();
        }
        }
}