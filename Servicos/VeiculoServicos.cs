using Entidades;
using Banco.Db;
using Enums;

namespace Servicos
{
    public class VeiculoServicos
    {
        Veiculos veiculo;
        MotoTricicloEntity motoTriciclo = new MotoTricicloEntity();
        CarroEntity carro = new CarroEntity();
        CamioneteEntity camionete = new CamioneteEntity();
        public void CadastrarVeiculo()
        {

            try
            {
                Console.Clear();
                Console.WriteLine("____________DEVCar____________");
                Console.WriteLine("Qual tipo de Veiculo Deseja Cadastrar:");
                Console.WriteLine("1-Moto/Triciclo");
                Console.WriteLine("2-Carros");
                Console.WriteLine("3-Camionete");
                string? escolha =Console.ReadLine();

                 switch(escolha)
                
                {
                    case "1":
                        motoTriciclo.Cadastro();
                        break;
                    case "2":
                        carro.Cadastro();
                        break;
                    case "3":
                        camionete.Cadastro();
                        break;
                    default:
                        throw new Exception("\nOpção inválida. Tente novamente.");
                        break;

                };
                
            }catch(FormatException)
            {
                Console.WriteLine("\nFormato não aceito. Tente novamente",
                Console.ForegroundColor = ConsoleColor.Red);
                Console.Read();
            }
            catch(Exception error)
            {
                Console.WriteLine($"{error.Message}",
                    Console.ForegroundColor = ConsoleColor.Red);
                    Console.Read();
            }
        
        }
        public void ListarVeiculos(){

            try
            {
                Console.Clear();
                Console.WriteLine("Escolha a Opção de Lista abaixo :");
                Console.WriteLine("1 - Motos e Triciclos.");
                Console.WriteLine("2 - Carros.");
                Console.WriteLine("3 - Camionetes");
                Console.WriteLine("4 - Todos os Veiculos.");
                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        motoTriciclo.ListarInformacoes();
                        break;
                    case "2":
                        carro.ListarInformacoes();
                        break;
                    case "3":
                        camionete.ListarInformacoes();
                        break;
                    case "4":
                        Console.WriteLine("Lista Completa");
                        motoTriciclo.ListarInformacoes();
                        carro.ListarInformacoes();
                        camionete.ListarInformacoes();
                        break;

                    default:
                        throw new Exception("\nOpção inválida. Tente novamente.");
                        break;
                }
            }catch(FormatException)
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
        public void DeletarVeiculo(string? veiculoEscolhido) 
        {

                if (BancoDeDados.MotosTriciclo.Count > 0)
            { 
                foreach (var motos in BancoDeDados.MotosTriciclo.ToList())
                if (motos.Nome == veiculoEscolhido)
                {
                    var moto = BancoDeDados.MotosTriciclo.FirstOrDefault(moto => moto.Nome == veiculoEscolhido);
                
                    BancoDeDados.MotosTriciclo.RemoveAll(veiculo => moto.Nome == veiculoEscolhido);
                    Console.WriteLine($"\nveiculo de {moto.Nome} removida com sucesso!",
                    Console.ForegroundColor = ConsoleColor.Blue);
                }

            }


            if (BancoDeDados.Carros.Count > 0)
            {
                foreach (var carros in BancoDeDados.Carros.ToList())
                    if (carros.Nome == veiculoEscolhido)
                    {
                        var carro = BancoDeDados.Carros.FirstOrDefault(carro => carro.Nome == veiculoEscolhido);
                        if (carro.Nome == veiculoEscolhido)
                        {
                            BancoDeDados.Carros.RemoveAll(carro => carro.Nome == veiculoEscolhido);
                            Console.WriteLine($"\nveiculo de {carro.Nome} removida com sucesso!",
                            Console.ForegroundColor = ConsoleColor.Blue);
                        }
                }
            }

            if (BancoDeDados.Camionete.Count > 0)
            {
                foreach (var camionetes in BancoDeDados.Camionete.ToList())
                    if (camionetes.Nome == veiculoEscolhido)
                    {
                        var camionete = BancoDeDados.Camionete.FirstOrDefault(camionete => camionete.Nome == veiculoEscolhido);
                        if (camionete.Nome == veiculoEscolhido)
                        {
                            BancoDeDados.Camionete.RemoveAll(camionete => camionete.Nome == veiculoEscolhido);
                            Console.WriteLine($"\nveiculo de {camionete.Nome} removida com sucesso!",
                            Console.ForegroundColor = ConsoleColor.Blue);
                        }
                }
            }
                

        }
        public void AtualizarVeiculo(string? veiculoEscolhido)
        {
            if (BancoDeDados.Camionete.Count > 0)
            {
                foreach (var camionetes in BancoDeDados.Camionete.ToList())
                    if (camionetes.Nome == veiculoEscolhido)
                    {
                        camionete.AletrarInformacoes(veiculoEscolhido);
                    }
            }
            if (BancoDeDados.Carros.Count > 0)
            {
                foreach (var carros in BancoDeDados.Carros.ToList())
                    if (carros.Nome == veiculoEscolhido)
                    {
                        carro.AletrarInformacoes(veiculoEscolhido);
                    }
            }
            if (BancoDeDados.MotosTriciclo.Count > 0)
            {
                foreach (var motos in BancoDeDados.MotosTriciclo.ToList())
                    if (motos.Nome == veiculoEscolhido)
                    {
                        motoTriciclo.AletrarInformacoes(veiculoEscolhido);
                    }
            }

        }
        public void CarrosVendidos(){
            if (BancoDeDados.Camionete.Count > 0)
            { camionete.VeiculosVendidos(); }
            if (BancoDeDados.Carros.Count > 0)
            { carro.VeiculosVendidos(); }
            if (BancoDeDados.MotosTriciclo.Count > 0)
            { motoTriciclo.VeiculosVendidos(); }

        }
        public void CarrosDisponiveis(){

            if (BancoDeDados.Camionete.Count > 0)
            { camionete.VeiculosDisponiveis(); }
            if (BancoDeDados.Carros.Count > 0)
            { carro.VeiculosDisponiveis(); }
            if (BancoDeDados.MotosTriciclo.Count > 0)
            { motoTriciclo.VeiculosDisponiveis(); }

            
        }
        public void CarrosVendidosComMaiorValor()
        {
            if (BancoDeDados.MotosTriciclo.Count > 0)
            {
                int? valor = 0;
                string? nome = "";
                foreach (var moto in BancoDeDados.MotosTriciclo)

                {

                    for (int i = 0; i < BancoDeDados.MotosTriciclo.Count; i++)
                    {

                        if (moto.CPF != "00000000000")
                        {

                            if (moto.Valor > valor)
                            {
                                valor = moto.Valor;
                                nome = moto.Nome;
                            }

                        }
                    }

                }
                Console.WriteLine("\nMoto/Triciclo Vendido com Maior Valor:"); Console.WriteLine($"Moto de nome {nome} foi vendido a R${valor}");


            }
            if (BancoDeDados.Carros.Count > 0)
            {
                int? valor = 0;
                string? nome = "";
                foreach (var carro in BancoDeDados.Carros)

                {

                    for (int i = 0; i < BancoDeDados.Carros.Count; i++)
                    {

                        if (carro.CPF != "00000000000")
                        {

                            if (carro.Valor > valor)
                            {
                                valor = carro.Valor;
                                nome = carro.Nome;
                            }

                        }
                    }

                }
                Console.WriteLine("\nMoto/Triciclo Vendido com Maior Valor:"); Console.WriteLine($"Moto de nome {nome} foi vendido a R${valor}");


            }
            if (BancoDeDados.Camionete.Count > 0)
            {
                int? valor = 0;
                string? nome = "";
                foreach (var camionete in BancoDeDados.Camionete)

                {

                    for (int i = 0; i < BancoDeDados.Camionete.Count; i++)
                    {

                        if (camionete.CPF != "00000000000")
                        {

                            if (camionete.Valor > valor)
                            {
                                valor = camionete.Valor;
                                nome = camionete.Nome;
                            }

                        }
                    }

                }
                Console.WriteLine("\nMoto/Triciclo Vendido com Maior Valor:"); Console.WriteLine($"Moto de nome {nome} foi vendido a R${valor}");

            }

        }
        public void CarrosVendidosComMenorValor()
        {
            if (BancoDeDados.MotosTriciclo.Count > 0)
            {
                int? valor = 9999999;
                string? nome = "";
                foreach (var moto in BancoDeDados.MotosTriciclo)

                {

                    for (int i = 0; i < BancoDeDados.MotosTriciclo.Count; i++)
                    {

                        if (moto.CPF != "00000000000")
                        {

                            if (moto.Valor < valor)
                            {
                                valor = moto.Valor;
                                nome = moto.Nome;
                            }

                        }
                    }

                }
                Console.WriteLine("\nMoto/Triciclo Vendido com Maior Valor:"); Console.WriteLine($"Moto de nome {nome} foi vendido a R${valor}");


            }
            if (BancoDeDados.Carros.Count > 0)
            {
                int? valor = 9999999;
                string? nome = "";
                foreach (var carro in BancoDeDados.Carros)

                {

                    for (int i = 0; i < BancoDeDados.Carros.Count; i++)
                    {

                        if (carro.CPF != "00000000000")
                        {

                            if (carro.Valor < valor)
                            {
                                valor = carro.Valor;
                                nome = carro.Nome;
                            }

                        }
                    }

                }
                Console.WriteLine("\nMoto/Triciclo Vendido com Maior Valor:"); Console.WriteLine($"Moto de nome {nome} foi vendido a R${valor}");


            }
            if (BancoDeDados.Camionete.Count > 0)
            {
                int? valor = 9999999;
                string? nome = "";
                foreach (var camionete in BancoDeDados.Camionete)

                {

                    for (int i = 0; i < BancoDeDados.Camionete.Count; i++)
                    {

                        if (camionete.CPF != "00000000000")
                        {

                            if (camionete.Valor < valor)
                            {
                                valor = camionete.Valor;
                                nome = camionete.Nome;
                            }

                        }
                    }

                }
                Console.WriteLine("\nMoto/Triciclo Vendido com Maior Valor:"); Console.WriteLine($"Moto de nome {nome} foi vendido a R${valor}");

            }
        } 
        public void VenderVeiculo(string? veiculoEscolhido){
            try
            {
                if (BancoDeDados.Camionete.Count > 0)
                {
                    foreach (var camionetes in BancoDeDados.Camionete.ToList())
                        if (camionetes.Nome == veiculoEscolhido)
                        {
                            camionete.VenderVeiculo(veiculoEscolhido);
                        }
                }
                if (BancoDeDados.Carros.Count > 0)
                {
                    foreach (var carros in BancoDeDados.Carros.ToList())
                        if (carros.Nome == veiculoEscolhido)
                        {
                            carro.VenderVeiculo(veiculoEscolhido);
                        }
                }
                if (BancoDeDados.MotosTriciclo.Count > 0)
                {
                    foreach (var motos in BancoDeDados.MotosTriciclo.ToList())
                        if (motos.Nome == veiculoEscolhido)
                        {
                            motoTriciclo.VenderVeiculo(veiculoEscolhido);
                        }
                }

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