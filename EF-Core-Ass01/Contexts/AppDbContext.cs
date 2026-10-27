using EF_Core_Ass01.Models;
using Microsoft.EntityFrameworkCore;
namespace EF_Core_Ass01.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BookStore;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
