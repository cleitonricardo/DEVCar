namespace Entidades
{

    public class MotosTriciclo : Veiculos
    {
        public int Potencia{get;set;}
        public int Rodas{get;set;}

        public MotosTriciclo(int rodas,
                             int potencia,
                             string DataFabricacao,
                             string Nome,
                             string Placa,
                             uint Valor,
                             string Cor):base(DataFabricacao,Nome,Placa,Valor,Cor)
                         
        {
          Potencia = potencia;
          Rodas = rodas;
        }
    }
}