using System.Linq;
using Microsoft.EntityFrameworkCore;
using Blazor.Entidades;
namespace Blazor.DAL;
public class ProductsContext : DbContext
{

    public ProductsContext() { }
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
    {
    }
    public DbSet<Productos> Productos { get; set; }
    public DbSet<ProductoDetalles> ProductoDetalles { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        var configuration = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json")
                       .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlite(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


    }

}
