using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GeoProf.Data;
using GeoProf.Models;

namespace GeoProf.Pages.Verlof
{
    public class CreateModel : PageModel
    {
        private readonly GeoProf.Data.ApplicationDbContext _context;

        public CreateModel(GeoProf.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VerlofAanvraag VerlofAanvraag { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VerlofAanvraag.Add(VerlofAanvraag);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
