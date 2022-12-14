using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectGeoProfs.Data;
using ProjectGeoProfs.Models;

namespace ProjectGeoProfs.Pages.Verlof
{
    public class EditModel : PageModel
    {
        private readonly ProjectGeoProfs.Data.ProjectGeoProfsContext _context;

        public EditModel(ProjectGeoProfs.Data.ProjectGeoProfsContext context)
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

            var verlofaanvraag =  await _context.VerlofAanvraag.FirstOrDefaultAsync(m => m.Id == id);
            if (verlofaanvraag == null)
            {
                return NotFound();
            }
            VerlofAanvraag = verlofaanvraag;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VerlofAanvraag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerlofAanvraagExists(VerlofAanvraag.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VerlofAanvraagExists(int id)
        {
          return (_context.VerlofAanvraag?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
