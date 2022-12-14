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
    public class IndexModel : PageModel
    {
        private readonly ProjectGeoProfs.Data.ProjectGeoProfsContext _context;

        public IndexModel(ProjectGeoProfs.Data.ProjectGeoProfsContext context)
        {
            _context = context;
        }

        public IList<VerlofAanvraag> VerlofAanvraag { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VerlofAanvraag != null)
            {
                VerlofAanvraag = await _context.VerlofAanvraag.ToListAsync();
            }
        }
    }
}
