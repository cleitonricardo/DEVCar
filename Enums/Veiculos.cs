   
namespace Enums
{
    public class Veiculos 
    {
        public int NumeroChassis {get;set;}
        public string? DataFabricacao {get;set;}
        public string? Nome {get;set;}
        public string? Placa {get;set;}
        public int? Valor {get;set;}
        public string? CPF {get;set;}
        public string? Cor {get;set;}
        public TipoVeiculo Tipo {get; set;}
        public MotosTriciclo MotosTriciclo{get;set;}
        public Camionete Camionete{get;set;}
        public Carros Carros{get;set;}

        public Veiculos()
            {
              
              
            }
        public virtual void Cadastro()
        {}
        public virtual void VenderVeiculo(string? veiculoEscolhido)
        { }
        public virtual void ListarInformacoes()
        { }
        public virtual void AletrarInformacoes(string? veiculoEscolhido)
        { }

    }
}