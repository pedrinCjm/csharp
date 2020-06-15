using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoComLogin.Models;

namespace ProjetoComLogin.Data
{
    public class ProjetoComLoginContext : DbContext
    {
        public ProjetoComLoginContext(DbContextOptions<ProjetoComLoginContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoComLogin.Models.Partida> Partida { get; set; }
    }
}
