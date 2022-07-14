namespace Entidades
{

    public class Camionete: Veiculos
    {
        public int Portas{get;set;}
        public int Cacamba{get;set;}
        public int Potencia{get;set;}
        public string? Combustivel{get;set;}

        public Camionete(int portas,
                         int cacamba,
                         int potencia,
                         string combustivel,
                         string DataFabricacao,
                         string Nome,
                         string Placa,
                         uint Valor,
                         string Cor):base(DataFabricacao,Nome,Placa,Valor,Cor)
         {
          Portas = portas;
          Cacamba = cacamba;
          Potencia = potencia;
          Combustivel = combustivel;

         }
    }
}