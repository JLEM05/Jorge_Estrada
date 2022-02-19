using System.Linq;
using Jorge_Estrada.Models;
using Microsoft.EntityFrameworkCore;

namespace Jorge_Estrada.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)   
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }    
    }
}
