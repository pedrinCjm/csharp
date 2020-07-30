using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComSenha.Models
{
    public class Acao
    {
        [Display(Name = "ID")]
        public int AcaoID { get; set; }
        [Display(Name = "Ação")]
        public string AcaoName { get; set; }
        [Display(Name = "Empresa")]
        public string AcaoEmpresa { get; set; }
        [Display(Name = "Tipo")]
        public string AcaoTipo { get; set; }
        [Display(Name = "Qtd")]
        public string AcaoQuatidade { get; set; }
        [Display(Name = "Valor")]
        public string AcaoValor { get; set; }
        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public string AcaoPreco { get; set; }
    }
}
