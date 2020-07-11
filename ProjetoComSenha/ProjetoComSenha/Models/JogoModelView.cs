using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoComSenha.Models
{
    public class JogoModelView
    {
        public int JogoModelViewId { get; set; }
        public string NoJogo { get; set; }
        public string DsJogo { get; set; }
        public int TipoJogoId { get; set; }
        public virtual TipoJogo TipoJogo { get; set; }
        public double JogadoresRegistrados { get; set; }
        public double JogadoresOnline { get; set; }
        public string CodigoPromocional { get; set; }
    }
}
