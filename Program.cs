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
            string? VeiculoEscolhido = "";

            VeiculoServicos veiculos = new VeiculoServicos();

            while (opcao != "10")
            {                              
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("____________DEVCar____________");
                Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO");
                Console.WriteLine("1-Cadastrar Novo Veiculo");
                Console.WriteLine("2-Deletar Veiculo");
                Console.WriteLine("3-Atualizar Veiculo");
                Console.WriteLine("4-Listar todos os carros");
                Console.WriteLine("5-Veiculos disponiveis");
                Console.WriteLine("6-Veiculos vendidos");
                Console.WriteLine("7-Veiculo vendido com o maior preço");
                Console.WriteLine("8-Veiculo vendido com o menor preço");
                Console.WriteLine("9-Vender Veiculo");
                Console.WriteLine("10-Sair");
                Console.WriteLine("O que você deseja:");
                opcao=Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                       veiculos.CadastrarVeiculo();
                    break;
                    case "2":
                    Console.Clear();
                    if (BancoDeDados.MotosTriciclo.Count >0 || BancoDeDados.Carros.Count > 0|| BancoDeDados.Camionete.Count > 0)
                        {
                        try{
                            veiculos.ListarVeiculos();
                            Console.WriteLine("Selecione um veiculo: ");
                            VeiculoEscolhido = Console.ReadLine();
                            veiculos.DeletarVeiculo(VeiculoEscolhido);
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
                    if (BancoDeDados.MotosTriciclo.Count > 0 || BancoDeDados.Carros.Count > 0 || BancoDeDados.Camionete.Count > 0)
                        {
                        try{
                            veiculos.ListarVeiculos();
                            Console.WriteLine("Selecione um Veiculo: ");
                            VeiculoEscolhido = Console.ReadLine();
                            veiculos.AtualizarVeiculo(VeiculoEscolhido);

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
                        if(BancoDeDados.MotosTriciclo.Count > 0 || BancoDeDados.Carros.Count > 0 || BancoDeDados.Camionete.Count > 0)
                        {
                            try
                            {
                                veiculos.ListarVeiculos();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato não aceito. Tente novamente",
                                Console.ForegroundColor = ConsoleColor.Red);
                            }
                        }else
                        {
                            Console.WriteLine("Não existe Veiculos cadastrado", Console.ForegroundColor = ConsoleColor.Red);
                        }
                        
                       
                    Console.Read();
                    break;
                    case "5":
                    Console.Clear();
                    if (BancoDeDados.MotosTriciclo.Count > 0 || BancoDeDados.Carros.Count > 0 || BancoDeDados.Camionete.Count > 0)
                    {
                        try
                        {
                            veiculos.CarrosDisponiveis();

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
                    case "6":
                    Console.Clear();
                    if (BancoDeDados.MotosTriciclo.Count > 0 || BancoDeDados.Carros.Count > 0 || BancoDeDados.Camionete.Count > 0)
                    {
                        try
                        {
                            veiculos.CarrosVendidos();

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
                    case "7":
                        Console.Clear();
                        if (BancoDeDados.MotosTriciclo.Count > 0 || BancoDeDados.Carros.Count > 0 || BancoDeDados.Camionete.Count > 0)
                        {
                            try
                            {
                                
                                veiculos.CarrosVendidosComMaiorValor();

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato não aceito. Tente novamente",
                                Console.ForegroundColor = ConsoleColor.Red);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não existe Veiculos cadastrado", Console.ForegroundColor = ConsoleColor.Red);
                        }
                        Console.Read();
                        break;
                    case "8":
                        Console.Clear();
                        if (BancoDeDados.MotosTriciclo.Count > 0 || BancoDeDados.Carros.Count > 0 || BancoDeDados.Camionete.Count > 0)
                        {
                            try
                            {
                                veiculos.CarrosVendidosComMenorValor();

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato não aceito. Tente novamente",
                                Console.ForegroundColor = ConsoleColor.Red);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não existe Veiculos cadastrado", Console.ForegroundColor = ConsoleColor.Red);
                        }
                        Console.Read();
                        break;
                    case "9":
                    Console.Clear();
                    if (BancoDeDados.MotosTriciclo.Count > 0 || BancoDeDados.Carros.Count > 0 || BancoDeDados.Camionete.Count > 0)
                        {
                        try{
                            veiculos.CarrosDisponiveis();
                            Console.WriteLine("Selecione um Veiculo: ");
                            VeiculoEscolhido = Console.ReadLine();
                            veiculos.VenderVeiculo(VeiculoEscolhido);

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
                }
            }
        }
    }
}
