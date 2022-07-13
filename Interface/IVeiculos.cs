using Entidades;
using Enums;

namespace Interfaces
{
    public interface IVeiculos
    {
         uint NumeroChassis {get;set;}
         string? DataFabricacao {get;set;}
        string? Nome {get;set;}
        uint Placa {get;set;}
         uint Valor {get;set;}
         uint CPF {get;set;}
        string? Cor {get;set;}
         TipoVeiculo Tipo {get; set;}

        void VenderVeiculo();
        void ListarInformacoes();
        void AlterarInformacoes(string Cor, uint valor);

    }
}