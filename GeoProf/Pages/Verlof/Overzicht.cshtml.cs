using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoProf.Data;
using GeoProf.Models;
using Microsoft.AspNetCore.Identity;

namespace GeoProf.Pages.Verlof
{
    public class OverzichtModel : PageModel
    {

        private readonly GeoProf.Data.ApplicationDbContext _context;

        public OverzichtModel(GeoProf.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<VerlofAanvraag> VerlofAanvraag { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VerlofAanvraag != null)
            {
                VerlofAanvraag = await _context.VerlofAanvraag.ToListAsync();
            }
        }
    }
}
