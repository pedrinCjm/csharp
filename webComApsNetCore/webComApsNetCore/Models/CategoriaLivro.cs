using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace webComApsNetCore.Models
{
    public class CategoriaLivro
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Livros> Livros { get; set; } = new List<Livros>();
    }
}
