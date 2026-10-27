using EF_Core_Ass01.Contexts;

namespace EF_Core_Ass01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext bookStore = new AppDbContext();
        }
    }
}
