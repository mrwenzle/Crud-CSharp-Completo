using Microsoft.EntityFrameworkCore;
using MeuPrimeiroCrud.Models;

namespace MeuPrimeiroCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Isso diz ao C#: "Existe uma tabela de Produtos no banco"
        public DbSet<Produto> Produtos { get; set; }
    }
}