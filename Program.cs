using Servicos;
using Banco.Db;
namespace DEVCar
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string? opcao="0";
            int NumeroChassis=0;
            uint Numero=1;

            while (opcao != "9")
            { 

                NumeroChassis= BancoDeDados.Veiculos.Count;
                if (BancoDeDados.Veiculos.Count >0)
                {
                    Numero =BancoDeDados.Veiculos.Last().NumeroChassis +1;
                }

                string? escolha="0";
                Console.Clear();
                Console.WriteLine("____________DEVCar____________");
                Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO");
                Console.WriteLine("1-Cadastrar Novo Veiculo");
                Console.WriteLine("2-Deletar Veiculo");
                Console.WriteLine("3-Atualizar Veiculo");
                Console.WriteLine("4-Listar todos os carros");
                Console.WriteLine("5-Carros disponiveis");
                Console.WriteLine("6-Carros vendidos");
                Console.WriteLine("7-Carro vendido com o maior preço");
                Console.WriteLine("8-Carro vendido com o menor preço");
                Console.WriteLine("9-Sair");
                Console.WriteLine("O que você deseja:");
                opcao=Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                       
                        while(escolha!="5"){
                        Console.Clear();
                        Console.WriteLine("Selecione o tipo do Veiculo:");
                        Console.WriteLine("1-Motos/Triciclo");
                        Console.WriteLine("2-Carros");
                        Console.WriteLine("3-Camionete");
                        Console.WriteLine("4-Todos");
                        Console.WriteLine("5-Voltar");
                        escolha=Console.ReadLine();
                        }

                    break;
                    case "2":
                    break;
                    case "3":
                    break;
                    case "4":
                    Console.Clear();
                    if (BancoDeDados.Veiculos.Count >0)
                    {
                        try
                        {
                            VeiculoServicos.ListarVeiculos();
                        }
                        catch(FormatException)
                        {

                        }
                    }
                    break;
                    case "5":
                    break;
                    case "6":
                    break;
                    case "7":
                    break;
                    case "8":
                    break;
                    case "9":
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
