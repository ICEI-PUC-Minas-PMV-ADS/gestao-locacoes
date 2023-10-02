using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaoLocacoes.Models;

namespace GestaoLocacoes.Data
{
    public class GestaoLocacoesContext : DbContext
    {
        public GestaoLocacoesContext (DbContextOptions<GestaoLocacoesContext> options)
            : base(options)
        {
        }

        public DbSet<GestaoLocacoes.Models.Product> Product { get; set; } = default!;
    }
}
