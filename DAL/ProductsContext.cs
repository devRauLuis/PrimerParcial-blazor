using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using Blazor.Entidades;
namespace Blazor.DAL;
public class ProductsContext : DbContext
{
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }
    public DbSet<Productos> Productos { get; set; }

}
