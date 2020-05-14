using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exo5.Models
{
    public class EtudiantContext : DbContext
    { 
        public EtudiantContext (DbContextOptions<EtudiantContext> options)
            : base(options)
        {
        }

        public DbSet<Exo5.Models.Etudiant> Etudiant { get; set; }
    }
}
