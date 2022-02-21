using System.Linq;
using Microsoft.EntityFrameworkCore;
using Blazor.Entidades;
namespace Blazor.DAL;
public class Context : DbContext
{

    public DbSet<Productos> Productos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=DATA/Productos.db");
    }
}
