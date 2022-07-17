   
namespace Enums
{
    public class Veiculos 
    {
        public int NumeroChassis {get;set;}
        public string? DataFabricacao {get;set;}
        public string? Nome {get;set;}
        public string? Placa {get;set;}
        public uint? Valor {get;set;}
        public string? CPF {get;set;}
        public string? Cor {get;set;}
        public TipoVeiculo Tipo {get; set;}
        public List<MotosTriciclo> MotosTriciclo{get;set;}
        public List<Camionete> Camionete{get;set;}
        public List<Carros> Carros{get;set;}

        public Veiculos()
            {
              
              
            }
            public virtual void Cadastro()
            {}
        
    }
}