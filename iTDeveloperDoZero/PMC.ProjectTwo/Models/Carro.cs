using System.ComponentModel.DataAnnotations;

namespace PMC.ProjectTwo.Models
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
