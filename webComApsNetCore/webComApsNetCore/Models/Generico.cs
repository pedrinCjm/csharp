using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webComApsNetCore.Models
{
    public class Generico
    {
        public int Id { get; set; }
        public Department department { get; set; }
        public Carro carro { get; set; }
    }
}
