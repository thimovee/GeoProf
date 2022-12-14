using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectGeoProfs.Data;
using ProjectGeoProfs.Models;

namespace ProjectGeoProfs.Pages.Verlof
{
    public class CreateModel : PageModel
    {
        private readonly ProjectGeoProfs.Data.ProjectGeoProfsContext _context;

        public CreateModel(ProjectGeoProfs.Data.ProjectGeoProfsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VerlofAanvraag VerlofAanvraag { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.VerlofAanvraag == null || VerlofAanvraag == null)
            {
                return Page();
            }

            _context.VerlofAanvraag.Add(VerlofAanvraag);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
