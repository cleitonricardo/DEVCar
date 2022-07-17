using Enums;

namespace Banco.Db  
{
    public static class BancoDeDados
    {
        public static List<Veiculos> Veiculos = new List<Veiculos>();
        public static DateOnly DataSistema = DateOnly.FromDateTime(DateTime.Now);

        public static List<MotosTriciclo> MotosTriciclo = new List<MotosTriciclo>();
        public static List<Carros> Carros = new List<Carros>();
        public static List<Camionete> Camionete = new List<Camionete>();

    }

    
}