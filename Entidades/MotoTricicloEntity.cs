using Enums;
using Banco.Db;

namespace Entidades
{
    public class MotoTricicloEntity : Veiculos
    {
        public MotoTricicloEntity(TipoVeiculo tipo)
        {
            MotosTriciclo motoTriciclo = new();
           
                       
            Console.Write("\nInforme a quantidade de Rodas:");
            motoTriciclo.Rodas = Console.ReadLine();
            Console.Write("\nInforme a Potencia:");
            motoTriciclo.Potencia = Console.ReadLine();

            BancoDeDados.Veiculos.Add(motoTriciclo);
        
        }
        }
}