using Enums;
using Banco.Db;
using Servicos;

namespace Entidades
{
    public class MotoTricicloEntity : Veiculos
    {

        public override void Cadastro()
        {

            try
            {
                MotosTriciclo moto = new();
                moto.NumeroChassis = 1;
                moto.Tipo = TipoVeiculo.MotosTriciclo;
                Console.WriteLine($"O numero do Chassis será: {NumeroChassis}");
                Console.Write("\nEntre com a data de fabricação :");
                
                moto.DataFabricacao =Console.ReadLine();
                Console.Write("\nEntre com o Nome :");
                moto.Nome = Console.ReadLine();
                CompradorServicos.ValidaString(moto.Nome);
                Console.Write("\nEntre com a Placa:");
                moto.Placa = Console.ReadLine();
                CompradorServicos.ValidaString(moto.Placa);
                moto.CPF = "00000000000";
                Console.Write("\nEntre com a cor:");
                moto.Cor = Console.ReadLine();
                CompradorServicos.ValidaString(moto.Cor);
                Console.Write("\nInforme o Valor: R$");
                moto.Valor =Convert.ToInt32( Console.ReadLine());
                Console.Write("\nInforme a quantidade de Rodas:");
                
                moto.Rodas = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nInforme a Potencia:");
                
                moto.Potencia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nveiculo {moto.Nome} cadastrado com sucesso!",
                   Console.ForegroundColor = ConsoleColor.Green);
                Console.ReadLine();

                Banco.Db.BancoDeDados.MotosTriciclo.Add(moto);

            }
            catch (FormatException)
            {
                Console.WriteLine("\nFormato não aceito. Tente novamente",
                Console.ForegroundColor = ConsoleColor.Red);
                Console.Read();
            }
            catch (Exception error)
            {
                Console.WriteLine($"{error.Message}",
                   Console.ForegroundColor = ConsoleColor.Red);
                Console.Read();
            }
        }
        public override void ListarInformacoes()
        {
            if (BancoDeDados.MotosTriciclo.Count > 0)
            {
                Console.WriteLine("\nLista de Motos/Triciclos:");
                foreach (var moto in BancoDeDados.MotosTriciclo)
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {moto.Nome} - Numero Chassis: {moto.NumeroChassis} - Data de Fabricação: {moto.DataFabricacao}" +
                                     $"\nPlaca: {moto.Placa} - Cor: {moto.Cor} - Valor de Compra: R${moto.Valor}" +
                                     $"\nNumero de Rodas: {moto.Rodas} - Potencia: {moto.Potencia}",
                                     Console.ForegroundColor = ConsoleColor.Yellow);
            }
        }
        public override void AletrarInformacoes(string? veiculoEscolhido)
        {
            for (int i = 0; i < BancoDeDados.MotosTriciclo.Count; i++)
            {
                if (BancoDeDados.MotosTriciclo[i].Nome == veiculoEscolhido)
                {
                    try
                    {
                        Console.Write($"Está é a cor atual do Veiculo {BancoDeDados.MotosTriciclo[i].Cor}. \nEntre com a nova cor do veiculo: ");
                        string? cor = Console.ReadLine();
                        CompradorServicos.ValidaString(cor);
                        BancoDeDados.MotosTriciclo[i].Cor = cor;
                        Console.Write($"Está é o valor atual do Veiculo R${BancoDeDados.MotosTriciclo[i].Valor}. \nEntre com a novo valor do veiculo: R$");
                        string? valor = Console.ReadLine();
                        CompradorServicos.ValidaString(valor);
                        BancoDeDados.MotosTriciclo[i].Valor = Convert.ToInt32(valor);
                        Console.WriteLine($"\nveiculo Atualizado com sucesso!",
                   Console.ForegroundColor = ConsoleColor.Green);
                    }
                    catch (FormatException)
                    {

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message,
                                Console.ForegroundColor = ConsoleColor.Red);
                        Console.Read();
                    }
                }
            }
        }
        public override void VenderVeiculo(string? veiculoEscolhido)
        {
            for (int i = 0; i < BancoDeDados.MotosTriciclo.Count; i++)
            {

                if (BancoDeDados.MotosTriciclo[i].Nome == veiculoEscolhido)
                {
                    try
                    {
                        Console.Write($"Entre com o CPF do comprador do veiculo: ");
                        string? CPF = Console.ReadLine();
                        CompradorServicos.ValidaCPF(CPF);

                        BancoDeDados.MotosTriciclo[i].CPF = CPF;
                        Console.WriteLine($"\nveiculo de {veiculoEscolhido} vendido com sucesso! para o CPF : {CPF}",
                    Console.ForegroundColor = ConsoleColor.Blue);
                    }
                    catch (FormatException)
                    {

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message,
                                Console.ForegroundColor = ConsoleColor.Red);
                        Console.Read();
                    }
                }
            }
        }
        public void VeiculosDisponiveis()
        {
            Console.WriteLine("\nLista de motos e triciclos disponiveis:", Console.ForegroundColor = ConsoleColor.White);
            foreach (var moto in BancoDeDados.MotosTriciclo)
            {
                
                if (moto.CPF == "00000000000")
                {
                    
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {moto.Nome} - Numero Chassis: {moto.NumeroChassis} - Data de Fabricação: {moto.DataFabricacao}" +
                                     $"\nPlaca: {moto.Placa} - Cor: {moto.Cor} - Valor de Compra: R${moto.Valor}" +
                                     $"\nNumero de Rodas: {moto.Rodas} - Potencia: {moto.Potencia}",
                                     Console.ForegroundColor = ConsoleColor.Yellow);
                }
            }
        }
        public void VeiculosVendidos()
        {
            Console.WriteLine("\nLista de motos e triciclos vendidos:", Console.ForegroundColor = ConsoleColor.White);
            foreach (var moto in BancoDeDados.MotosTriciclo)
            {
                
                if (moto.CPF != "00000000000")
                {
                    
                    Console.WriteLine("-----------------------------------------------------------" +
                                     $"\nNome: {moto.Nome} - Numero Chassis: {moto.NumeroChassis} - Data de Fabricação: {moto.DataFabricacao}" +
                                     $"\nPlaca: {moto.Placa} - Cor: {moto.Cor} - Valor de Compra: R${moto.Valor}" +
                                     $"\nNumero de Rodas: {moto.Rodas} - Potencia: {moto.Potencia} - CPF do Comprador: {moto.CPF}",
                                     Console.ForegroundColor = ConsoleColor.Yellow);
                }
            }
        }
    }
}