using Entidades;
using Banco.Db;
using Enums;

namespace Servicos
{
    public class VeiculoServicos
    {
        public void CadastrarVeiculo()
        {
                Veiculos conta;
            
            try
            {
                Console.Clear();
                Console.WriteLine("____________DEVCar____________");
                Console.WriteLine("Qual tipo de Veiculo Deseja Cadastrar:");
                Console.WriteLine("1-Moto/Triciclo");
                Console.WriteLine("2-Carros");
                Console.WriteLine("3-Camionete");
                string? escolha =Console.ReadLine();

                conta=escolha switch
                
                {
                    "1" => new MotosTriciclo(),
                    "2" => new Carros(),
                    "3" => new Camionete(),
                    _   => throw new Exception("\nOpção inválida. Tente novamente.")
                };
                conta.Tipo =(TipoVeiculo)Convert.ToInt32(escolha);
                conta.NumeroChassis = 1;  
                Console.WriteLine($"O numero do Chassis será: {conta.NumeroChassis}");
                Console.WriteLine("Entre com a data de fabricação :");
                conta.DataFabricacao = Console.ReadLine();
                CompradorServicos.ValidaString(conta.DataFabricacao);
                Console.WriteLine("Entre com o Nome :");
                conta.Nome =Console.ReadLine();
                CompradorServicos.ValidaString(conta.Nome);
                Console.WriteLine("Entre com a Placa:");
                conta.Placa =Console.ReadLine();
                CompradorServicos.ValidaString(conta.Placa);
                Console.WriteLine("Entre com o CPF do Comprador");
                conta.CPF= Console.ReadLine();
                CompradorServicos.ValidaCPF(conta.CPF);
                Console.WriteLine("Entre com a cor:");
                conta.Cor=Console.ReadLine();
                CompradorServicos.ValidaString(conta.Cor);
                Console.ReadLine();
                

                BancoDeDados.Veiculos.Add(conta);

              

            }catch(FormatException)
            {
                Console.WriteLine("\nFormato não aceito. Tente novamente",
                Console.ForegroundColor = ConsoleColor.Red);
            }
            catch(Exception error)
            {
                Console.WriteLine($"{error.Message}",
                    Console.ForegroundColor = ConsoleColor.Red);
                    Console.Read();
            }
        
        }
    
         public void ListarVeiculos(){

             List<Veiculos> listaDeVeiculos =new();

             foreach (var conta in BancoDeDados.Veiculos)
             {
               
                listaDeVeiculos.Add(conta);
             }

                
             listaDeVeiculos = BancoDeDados.Veiculos;

                Console.WriteLine("Lista Completa de Veiculos: ");

                if(listaDeVeiculos.Where(contas=>contas.Tipo == TipoVeiculo.MotosTriciclo).ToList().Count>0)
                {
                Console.WriteLine("Lista de Motos/Triciclos:");
                foreach (var conta in listaDeVeiculos.Where(contas => contas.Tipo == TipoVeiculo.MotosTriciclo))
             Console.WriteLine($"Este é o nome: {conta.Nome}");  
             }

             if(listaDeVeiculos.Where(contas=>contas.Tipo == TipoVeiculo.Carro).ToList().Count>0)
                {
                    Console.WriteLine("Lista de Carros:");
                    foreach (var conta in listaDeVeiculos.Where(contas => contas.Tipo == TipoVeiculo.Carro))
             Console.WriteLine($"Este é o nome: {conta.Nome}");
                }

            if(listaDeVeiculos.Where(contas=>contas.Tipo == TipoVeiculo.Camionete).ToList().Count>0)
                {
                    Console.WriteLine("Lista de Camionete:");
             foreach (var conta in listaDeVeiculos.Where(contas => contas.Tipo == TipoVeiculo.Camionete))
             Console.WriteLine($"Este é o nome: {conta.Nome}");
                }
        }
        public void DeletarVeiculo(){

            try
            {
                Console.Clear();
                Console.WriteLine("____________DEVCar____________");
                Console.WriteLine("Qual tipo de Veiculo Deseja Deletar:");
                Console.WriteLine("1-Moto/Triciclo");
                Console.WriteLine("2-Carros");
                Console.WriteLine("3-Camionete");
                string? escolha =Console.ReadLine();
            }catch(FormatException)
            {
                Console.WriteLine("Formato não aceito. Tente novamente",
                Console.ForegroundColor = ConsoleColor.Red);
            }
        }
        public void AtualizarVeiculo(){

        }
    }
}