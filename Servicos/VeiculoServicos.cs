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
                
                conta.CPF= "00000000000";
                
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
        public void DeletarVeiculo(string veiculoEscolhido){

                var conta = BancoDeDados.Veiculos.FirstOrDefault(conta =>conta.Nome == veiculoEscolhido);
                BancoDeDados.Veiculos.RemoveAll(conta => conta.Nome == veiculoEscolhido);
                 Console.WriteLine($"\nConta de {conta.Nome} removida com sucesso!",
                    Console.ForegroundColor = ConsoleColor.Blue);

        }
        public void AtualizarVeiculo(string veiculoEscolhido)
        {

            for (int i =0 ; i <BancoDeDados.Veiculos.Count; i++)
            {

                if(BancoDeDados.Veiculos[i].Nome == veiculoEscolhido)
                {
                try{
                    Console.Write($"O nome do titular é {BancoDeDados.Veiculos[i].Nome}. Entre com o novo nome do titular da conta: ");
                        string? nome = Console.ReadLine();
                        CompradorServicos.ValidaString(nome);

                        BancoDeDados.Veiculos[i].Nome =nome;
                }
                catch(FormatException){

                }
                catch(Exception error){
                    Console.WriteLine(error.Message,
                            Console.ForegroundColor = ConsoleColor.Red);
                        Console.Read();
                }
                }
            }
            
        }
        public void CarrosVendidos(){
            List<Veiculos> listaDeVeiculos =new();

            foreach (var conta in BancoDeDados.Veiculos)
             {
               
                listaDeVeiculos.Add(conta);
             }
             listaDeVeiculos = BancoDeDados.Veiculos;

             Console.WriteLine("Lista de Veiculos Vendidos: ");

                if(listaDeVeiculos.Where(contas=>contas.CPF != "00000000000").ToList().Count>0)
                {
                Console.WriteLine("Lista de Motos/Triciclos:");
                foreach (var conta in listaDeVeiculos.Where(contas => contas.CPF != "00000000000"))
             Console.WriteLine($"Este é o nome: {conta.Nome} CPF {conta.CPF}");  
             }

        }
        public void CarrosDisponiveis(){

            List<Veiculos> listaDeVeiculos =new();

            foreach (var conta in BancoDeDados.Veiculos)
             {
               
                listaDeVeiculos.Add(conta);
             }
             listaDeVeiculos = BancoDeDados.Veiculos;

             Console.WriteLine("Lista de Veiculos Vendidos: ");

                if(listaDeVeiculos.Where(contas=>contas.CPF == "00000000000").ToList().Count>0)
                {
                Console.WriteLine("Lista de Motos/Triciclos:");
                foreach (var conta in listaDeVeiculos.Where(contas => contas.CPF == "00000000000"))
             Console.WriteLine($"Este é o nome: {conta.Nome} CPF {conta.CPF}");  
             }
        }
        public void CarrosVendidosComMaiorValor(){}
        public void CarrosVendidosComMenorValor(){}    

    }
}