using System.ComponentModel.DataAnnotations;

namespace ProjetoComSenha.Models
{
    public class JogoModelView
    {
        public int JogoModelViewId { get; set; }
        [Display(Name = "Jogo")]
        public string NoJogo { get; set; }
        [Display(Name = "Descrição")]
        public string DsJogo { get; set; }
        public int TipoJogoId { get; set; }
        [Display(Name = "Tipo")]
        public virtual TipoJogo TipoJogo { get; set; }
        [Display(Name = "Jogadores Registrados")]
        public double JogadoresRegistrados { get; set; }
        [Display(Name = "Online")]
        public double JogadoresOnline { get; set; }
        [Display(Name = "Código")]
        public string CodigoPromocional { get; set; }
    }
}
