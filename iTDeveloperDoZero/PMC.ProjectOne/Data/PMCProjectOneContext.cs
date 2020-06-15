using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PMC.ProjectOne.Models;

namespace PMC.ProjectOne.Data
{
    public class PMCProjectOneContext : DbContext
    {
        public PMCProjectOneContext (DbContextOptions<PMCProjectOneContext> options)
            : base(options)
        {
        }

        public DbSet<PMC.ProjectOne.Models.Estoque> Estoque { get; set; }
    }
}
