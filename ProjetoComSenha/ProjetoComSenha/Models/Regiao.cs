using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComSenha.Models
{
    public class Regiao
    {
        public int RegiaoId { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
