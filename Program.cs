
namespace DEVCar
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string? opcao="0";
            
            while (opcao != "6")
            { 
                string? escolha="0";
                Console.Clear();
                Console.WriteLine("____________DEVCar____________");
                Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO");
                Console.WriteLine("1-Listar todos os carros");
                Console.WriteLine("2-Carros disponiveis");
                Console.WriteLine("3-Carros vendidos");
                Console.WriteLine("4-Carro vendido com o maior preço");
                Console.WriteLine("5-Carro vendido com o menor preço");
                Console.WriteLine("6-Sair");

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
                    break;
                    case "5":
                    break;
                    case "6":
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
