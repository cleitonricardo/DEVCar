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
            VeiculoServicos veiculos = new VeiculoServicos();

            while (opcao != "9")
            { 

                NumeroChassis= BancoDeDados.Veiculos.Count;
                if (BancoDeDados.Veiculos.Count >0)
                {
                    Numero =BancoDeDados.Veiculos.Last().NumeroChassis +1;
                }

                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
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
                       veiculos.CadastrarVeiculo();
                    break;
                    case "2":
                    Console.Clear();
                    if (BancoDeDados.Veiculos.Count >0){
                        try{
                            veiculos.DeletarVeiculo();
                        }
                        catch(FormatException){
                            Console.WriteLine("Formato não aceito. Tente novamente",
                            Console.ForegroundColor = ConsoleColor.Red);
                        }
                    }else{
                        Console.WriteLine("Não existe Veiculos cadastrado", Console.ForegroundColor=ConsoleColor.Red);
                    }
                    Console.Read();
                    break;
                    case "3":
                    Console.Clear();
                    if (BancoDeDados.Veiculos.Count >0){
                        try{
                            veiculos.AtualizarVeiculo();
                        }
                        catch(FormatException){
                            Console.WriteLine("Formato não aceito. Tente novamente",
                            Console.ForegroundColor = ConsoleColor.Red);
                        }
                    }else{
                        Console.WriteLine("Não existe Veiculos cadastrado", Console.ForegroundColor=ConsoleColor.Red);
                    }
                    Console.Read();
                    break;
                    case "4":
                    Console.Clear();
                    if (BancoDeDados.Veiculos.Count >0)
                    {
                        try
                        {
                            veiculos.ListarVeiculos();

                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Formato não aceito. Tente novamente",
                            Console.ForegroundColor = ConsoleColor.Red);
                        }
                    }else{
                        Console.WriteLine("Não existe Veiculos cadastrado", Console.ForegroundColor=ConsoleColor.Red);
                    }
                    Console.Read();
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
