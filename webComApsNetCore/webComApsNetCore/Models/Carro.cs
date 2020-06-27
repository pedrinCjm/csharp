using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webComApsNetCore.Models
{
    public class Carro
    {
        [Display(Name = "#")]
        public int id { get; set; }
        [Required]
        [Display(Name = "Placa")]
        public int placa { get; set; }
        [Display(Name = "Cor")]
        public string cor { get; set; }
    }
}
