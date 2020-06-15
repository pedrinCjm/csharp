using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webComApsNetCore.Models
{
    public class Carro
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Placa do carro")]
        public int placa { get; set; }
        public string cor { get; set; }
    }
}
