using Enums;

    
namespace Entidades
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

        public Veiculos(string dataDeFabricacao,
                        string nome,
                        string placa,
                        uint valor,
                        string cor)
            {
                DataFabricacao =dataDeFabricacao;
                Nome = nome;
                Placa = placa;
                Valor = valor;
                Cor = cor;
            }

        public void VenderVeiculo(){}
        public void ListarInformacoes(){}
        public void AlterarInformacoes(string Cor, uint valor){}

        
    }
}