using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComLogin.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CoJog1 { get; set; }
        public int CoJog2 { get; set; }
        public int CoTpJogo { get; set; }
    }
}
