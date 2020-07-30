using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoComSenha.Models;

namespace ProjetoComSenha.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjetoComSenha.Models.Partida> Partida { get; set; }
        public DbSet<ProjetoComSenha.Models.Regiao> Regiao { get; set; }
        public DbSet<ProjetoComSenha.Models.TipoJogo> TipoJogo { get; set; }
        public DbSet<ProjetoComSenha.Models.Jogo> Jogo { get; set; }
        public DbSet<ProjetoComSenha.Models.Jogador> Jogador { get; set; }
        public DbSet<ProjetoComSenha.Models.JogoModelView> JogoModelView { get; set; }
        public DbSet<ProjetoComSenha.Models.Acao> Acao { get; set; }
    }
}
