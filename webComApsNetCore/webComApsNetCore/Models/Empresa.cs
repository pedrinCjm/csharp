﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webComApsNetCore.Models
{
    public class Empresa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Department> Departamentos { get; set; } = new List<Department>();
    }
}
