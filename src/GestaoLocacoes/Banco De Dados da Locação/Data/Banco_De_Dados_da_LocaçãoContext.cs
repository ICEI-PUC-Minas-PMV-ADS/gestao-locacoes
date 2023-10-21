using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mf_dev_backend_2023.Models;

namespace Banco_De_Dados_da_Locação.Data
{
    public class Banco_De_Dados_da_LocaçãoContext : DbContext
    {
        public Banco_De_Dados_da_LocaçãoContext (DbContextOptions<Banco_De_Dados_da_LocaçãoContext> options)
            : base(options)
        {
        }

        public DbSet<mf_dev_backend_2023.Models.Usuario> Usuario { get; set; } = default!;
    }
}
