using Microsoft.EntityFrameworkCore;
using ProjetoComSenhaApi.Models;

namespace ProjetoComSenhaApi.Data
{
    public class ProjetoComSenhaApiContext : DbContext
    {
        public ProjetoComSenhaApiContext (DbContextOptions<ProjetoComSenhaApiContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoComSenhaApi.Models.Partida> Partida { get; set; }
        public DbSet<ProjetoComSenhaApi.Models.Regiao> Regiao { get; set; }
        public DbSet<ProjetoComSenhaApi.Models.Jogo> Jogo { get; set; }
        public DbSet<ProjetoComSenhaApi.Models.TipoJogo> TipoJogo { get; set; }
        public DbSet<ProjetoComSenhaApi.Models.Jogador> Jogador { get; set; }
        public DbSet<ProjetoComSenhaApi.Models.HistoricoPartida> HistoricoPartida { get; set; }
    }
}
