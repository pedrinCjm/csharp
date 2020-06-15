using System.Collections.Generic;

namespace ProjetoComSenhaApi.Models
{
    public class TipoJogo
    {
        public TipoJogo()
        {
            this.Jogos = new HashSet<Jogo>();
        }
        public int TipoJogoId { get; set; }
        public string NoTipoJogo { get; set; }
        public string DsTipoJogo { get; set; }
        public int QtdMaxJogadores { get; set; }
        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
