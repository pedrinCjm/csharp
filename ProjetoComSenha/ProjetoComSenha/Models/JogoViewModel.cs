using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComSenha.Models
{
    public class JogoViewModel
    {
        public Jogo Jogo { get; set; }
        public ICollection<TipoJogo> TipoJogo { get; set; }
    }
}
