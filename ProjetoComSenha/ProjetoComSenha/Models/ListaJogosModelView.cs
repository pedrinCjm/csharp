using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoComSenha.Models
{
    public class ListaJogosModelView
    {
        [Display(Name = "Jogo")]
        public string NoJogo { get; set; }
        [Display(Name = "Descrição")]
        public string DsJogo { get; set; }
        [Display(Name = "Tipo")]
        public int TipoJogoId { get; set; }
        [Display(Name = "Jogadores Registrados")]
        public double JogadoresRegistrados { get; set; }
        [Display(Name = "Online")]
        public double JogadoresOnline { get; set; }
        [Display(Name = "Código")]
        public string CodigoPromocional { get; set; }

        public DateTime? DtInicial { get; set; }
        public DateTime? DtFinal { get; set; }

        public List<JogoModelView> JogoModelView;
    }
}
