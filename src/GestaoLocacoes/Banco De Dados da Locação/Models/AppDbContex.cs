using mf_dev_backend_2023.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco_De_Dados_da_Locação.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        



    }

}
