using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectGeoProfs.Models;

namespace ProjectGeoProfs.Data
{
    public class ProjectGeoProfsContext : IdentityDbContext
    {
        public ProjectGeoProfsContext (DbContextOptions<ProjectGeoProfsContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectGeoProfs.Models.VerlofAanvraag> VerlofAanvraag { get; set; } = default!;
    }
}
