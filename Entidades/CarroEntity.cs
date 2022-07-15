using Enums;

namespace Entidades
{
    public class CarroEntity : Veiculos
    {
        public CarroEntity(TipoVeiculo tipo)
        {
            Carros carros = new();


            Console.WriteLine("Informe a quantidade de Portas:");
            carros.Portas = Console.ReadLine();
            Console.WriteLine("Informe o tipo de Combustivel:");
            carros.Combustivel = Console.ReadLine();        
            Console.WriteLine("Informe a Potencia:");
            carros.Potencia = Console.ReadLine();
        }
        }
        }
