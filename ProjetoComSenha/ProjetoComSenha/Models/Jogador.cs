using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComSenha.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [Display(Name = "Nome")]
        public string NoJogador { get; set; }
        [Required(ErrorMessage = "O nick name é obrigatório!")]
        [Display(Name = "Nick name")]
        public string NickJogador { get; set; }
        public virtual HistoricoPartida HistoricoPartidas { get; set; }
    }
}
