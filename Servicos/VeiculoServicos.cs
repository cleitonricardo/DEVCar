using Entidades;
using Banco.Db;
using Enums;

namespace Servicos
{
    public class VeiculoServicos
    {
        public void CadastrarVeiculo(int numero)
        {
                Veiculos veiculo;
                MotoTricicloEntity motoTriciclo = new MotoTricicloEntity();
                CarroEntity carro = new CarroEntity();
                 CamioneteEntity camionete = new CamioneteEntity();
                
            
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

             List<Veiculos> listaDeVeiculos = new();
            foreach (var carro in Banco.Db.BancoDeDados.Veiculos)
            {
                listaDeVeiculos.Add(carro);
            }

            listaDeVeiculos = Banco.Db.BancoDeDados.Veiculos;

            Console.WriteLine("Lista Completa");

            

            if (listaDeVeiculos.Where(moto => moto.Tipo == TipoVeiculo.MotosTriciclo).ToList().Count > 0)
            {
                Console.WriteLine("Lista de Motos/Triciclos:");
                foreach (var moto in listaDeVeiculos.Where(moto => moto.Tipo == TipoVeiculo.MotosTriciclo))
                    Console.WriteLine($"Este é o nome: {moto.Nome}");
                
            }
            if (listaDeVeiculos.Where(carro => carro.Tipo == TipoVeiculo.Carro).ToList().Count > 0)
            {
                Console.WriteLine("Lista de Carros");
                foreach (var carro in listaDeVeiculos.Where(carro => carro.Tipo == TipoVeiculo.Carro))
                    Console.WriteLine($"Este é o nome: {carro.Nome}");
                
            }

            if (listaDeVeiculos.Where(camionete => camionete.Tipo == TipoVeiculo.Camionete).ToList().Count > 0)
            {
                
                Console.WriteLine("Lista de Camionete");
                foreach (var camionete in listaDeVeiculos.Where(camionete => camionete.Tipo == TipoVeiculo.Camionete))
                    Console.WriteLine($"Este é o nome: {camionete.Nome}");
                
            }
        }
        public void DeletarVeiculo(string? veiculoEscolhido){

                var veiculo = BancoDeDados.Veiculos.FirstOrDefault(veiculo =>veiculo.Nome == veiculoEscolhido);
                BancoDeDados.Veiculos.RemoveAll(veiculo => veiculo.Nome == veiculoEscolhido);
                 Console.WriteLine($"\nveiculo de {veiculo.Nome} removida com sucesso!",
                    Console.ForegroundColor = ConsoleColor.Blue);

        }
        public void AtualizarVeiculo(string? veiculoEscolhido)
        {

            for (int i =0 ; i <BancoDeDados.Veiculos.Count; i++)
            {

                if(BancoDeDados.Veiculos[i].Nome == veiculoEscolhido)
                {
                try{
                    Console.Write($"O nome do titular é {BancoDeDados.Veiculos[i].Nome}. Entre com o novo nome do titular da veiculo: ");
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

            foreach (var veiculo in BancoDeDados.Veiculos)
             {
               
                listaDeVeiculos.Add(veiculo);
             }
             listaDeVeiculos = BancoDeDados.Veiculos;

             Console.WriteLine("Lista de Veiculos Vendidos: ");

                if(listaDeVeiculos.Where(veiculos=>veiculos.CPF != "00000000000").ToList().Count>0)
                {
                Console.WriteLine("Lista de Motos/Triciclos:");
                foreach (var veiculo in listaDeVeiculos.Where(veiculos => veiculos.CPF != "00000000000"))
             Console.WriteLine($"Este é o nome: {veiculo.Nome} CPF {veiculo.CPF}");  
             }else{
               Console.WriteLine("Não existe Veiculos Vendidos", Console.ForegroundColor=ConsoleColor.Red);
             }

        }
        public void CarrosDisponiveis(){

            List<Veiculos> listaDeVeiculos =new();

            foreach (var veiculo in BancoDeDados.Veiculos)
             {
               
                listaDeVeiculos.Add(veiculo);
             }
             listaDeVeiculos = BancoDeDados.Veiculos;

             Console.WriteLine("Lista de Veiculos Vendidos: ");

                if(listaDeVeiculos.Where(veiculos=>veiculos.CPF == "00000000000").ToList().Count>0)
                {
                Console.WriteLine("Lista de Motos/Triciclos:");
                foreach (var veiculo in listaDeVeiculos.Where(veiculos => veiculos.CPF == "00000000000"))
             Console.WriteLine($"Este é o nome: {veiculo.Nome} CPF {veiculo.CPF}");  
             }else{
               Console.WriteLine("Não existe Veiculos Disponiveis", Console.ForegroundColor=ConsoleColor.Red);
             }
        }
        public void CarrosVendidosComMaiorValor(){}
        public void CarrosVendidosComMenorValor(){} 

        public void VenderVeiculo(string? veiculoEscolhido){
                for (int i =0 ; i <BancoDeDados.Veiculos.Count; i++)
            {

                if(BancoDeDados.Veiculos[i].Nome == veiculoEscolhido)
                {
                try{
                    Console.Write($"Entre com o CPF do comprador do veiculo: ");
                        string? CPF = Console.ReadLine();
                        CompradorServicos.ValidaCPF(CPF);

                        BancoDeDados.Veiculos[i].CPF =CPF;
                        Console.WriteLine($"\nveiculo de {veiculoEscolhido} vendido com sucesso! para o CPF : {CPF}",
                    Console.ForegroundColor = ConsoleColor.Blue);
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

    }
}