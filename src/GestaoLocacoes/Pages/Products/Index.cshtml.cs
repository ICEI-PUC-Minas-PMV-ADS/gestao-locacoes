using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestaoLocacoes.Data;
using GestaoLocacoes.Models;

namespace GestaoLocacoes.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly GestaoLocacoes.Data.GestaoLocacoesContext _context;

        public IndexModel(GestaoLocacoes.Data.GestaoLocacoesContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
