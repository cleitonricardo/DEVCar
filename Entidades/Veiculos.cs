using Enums;
using Interfaces;
    
namespace Entidades
{
    public class Veiculos : IVeiculos
    {
        public uint NumeroChassis {get;set;}
        public string? DataFabricacao {get;set;}
        public string? Nome {get;set;}
        public string? Placa {get;set;}
        public uint Valor {get;set;}
        public string? CPF {get;set;}
        public string? Cor {get;set;}
        public TipoVeiculo Tipo {get; set;}

        public void VenderVeiculo(){}
        public void ListarInformacoes(){}
        public void AlterarInformacoes(string Cor, uint valor){}

        
    }
}