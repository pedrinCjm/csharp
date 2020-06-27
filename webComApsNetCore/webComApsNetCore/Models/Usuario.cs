using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webComApsNetCore.Models
{
    public class Usuario
    {
        public decimal UsuarioId { get; set; }
        public string NoUsuario { get; set; }
        public decimal CPF { get; set; }
        public decimal Telefone { get; set; }
        public decimal CEP { get; set; }
        public decimal CNPJ { get; set; }
        public DateTime UsuDatNasc { get; set; }

    }
}
