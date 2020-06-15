using System.Collections.Generic;

namespace ProjetoComSenhaApi.Models
{
    public class HistoricoPartida
    {
        public HistoricoPartida()
        {
            this.Partidas = new HashSet<Partida>();
        }

        public int HistoricoPartidaId { get; set; }
        public int JogadorId { get; set; }
        public virtual Jogador Jogador { get; set; }
        public virtual ICollection<Partida> Partidas { get; set; }
    }
}
