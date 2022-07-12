using Entidades;

namespace Banco.Db  
{
    public static class BancoDeDados
    {
        public static List<Veiculos> Veiculos = new List<Veiculos>();
        public static DateOnly DataSistema = DateOnly.FromDateTime(DateTime.Now);
    }
}