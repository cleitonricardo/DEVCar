using Enums;
using Banco.Db;

namespace Entidades
{
    public class MotoTricicloAcao : Veiculos
    {
        public MotoTricicloAcao(TipoVeiculo tipo)
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