using System.Collections.Generic;

namespace ProjetoComSenhaApi.Models
{
    public class Partida
    {
        public Partida()
        {
            this.Jogadores = new HashSet<Jogador>();
        }

        public int PartidaId { get; set; }
        public string ObsPartida { get; set; }
        public string VencedorJogo { get; set; }
        public int JogoId { get; set; }
        public virtual Jogo Jogo { get; set; }
        public virtual ICollection<Jogador> Jogadores { get; set; }
    }
}