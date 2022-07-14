namespace Entidades
{

    public class Carros: Veiculos
    {
        public int Portas{get;set;}
        public string? Combustivel{get;set;}
        public int Potencia{get;set;}

        public Carros(int portas,
                      int potencia,
                      string combustivel,
                      string DataFabricacao,
                      string Nome,
                      string Placa,
                      uint Valor,
                      string Cor):base(DataFabricacao,Nome,Placa,Valor,Cor)
                         
        {
          Portas = portas;  
          Potencia = potencia;
          Combustivel = combustivel;
        }
    }
}