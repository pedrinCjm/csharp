using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PMC.ProjectTwo.Models;

namespace PMC.ProjectTwo.Data
{
    public class PMCProjectTwoContext : DbContext
    {
        public PMCProjectTwoContext (DbContextOptions<PMCProjectTwoContext> options)
            : base(options)
        {
        }

        public DbSet<PMC.ProjectTwo.Models.Carro> Carro { get; set; }
    }
}
