using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webComApsNetCore.Models;

namespace webComApsNetCore.Data
{
    public class webComApsNetCoreContext : DbContext
    {
        public webComApsNetCoreContext (DbContextOptions<webComApsNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<webComApsNetCore.Models.Departaments> Departaments { get; set; }
    }
}
