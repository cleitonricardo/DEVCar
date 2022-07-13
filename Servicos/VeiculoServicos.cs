using Entidades;
using Banco.Db;

namespace Servicos
{
    public class VeiculoServicos
    {
        public void CadastrarVeiculo(uint Tipo=0)
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

               // Veiculos.NumeroChassis =Numero;

            }catch(FormatException)
            {

            }
        }
    
    public void ListarVeiculos(){

    }
    }
}