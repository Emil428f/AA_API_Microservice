using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Context;
using Model;

namespace WebAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EntityFramework.Context.ApplicationDbContext _context;

        public IndexModel(EntityFramework.Context.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Gps> Gps { get;set; }

        public async Task OnGetAsync()
        {
            Gps = await _context.Gps.ToListAsync();
        }
    }
}
