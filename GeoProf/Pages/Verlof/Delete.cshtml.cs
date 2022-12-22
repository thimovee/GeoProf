using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoProf.Data;
using GeoProf.Models;

namespace GeoProf.Pages.Verlof
{
    public class DeleteModel : PageModel
    {
        private readonly GeoProf.Data.ApplicationDbContext _context;

        public DeleteModel(GeoProf.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public VerlofAanvraag VerlofAanvraag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VerlofAanvraag == null)
            {
                return NotFound();
            }

            var verlofaanvraag = await _context.VerlofAanvraag.FirstOrDefaultAsync(m => m.Id == id);

            if (verlofaanvraag == null)
            {
                return NotFound();
            }
            else 
            {
                VerlofAanvraag = verlofaanvraag;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.VerlofAanvraag == null)
            {
                return NotFound();
            }
            var verlofaanvraag = await _context.VerlofAanvraag.FindAsync(id);

            if (verlofaanvraag != null)
            {
                VerlofAanvraag = verlofaanvraag;
                _context.VerlofAanvraag.Remove(VerlofAanvraag);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
