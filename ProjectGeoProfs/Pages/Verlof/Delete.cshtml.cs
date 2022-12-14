using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectGeoProfs.Data;
using ProjectGeoProfs.Models;

namespace ProjectGeoProfs.Pages.Verlof
{
    public class DeleteModel : PageModel
    {
        private readonly ProjectGeoProfs.Data.ProjectGeoProfsContext _context;

        public DeleteModel(ProjectGeoProfs.Data.ProjectGeoProfsContext context)
        {
            _context = context;
        }

        [BindProperty]
      public VerlofAanvraag VerlofAanvraag { get; set; } = default!;

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
