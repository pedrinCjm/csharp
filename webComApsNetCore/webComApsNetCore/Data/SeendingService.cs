using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webComApsNetCore.Models;

namespace webComApsNetCore.Data
{
    public class SeendingService
    {
        private webComApsNetCoreContext _context;

        public SeendingService (webComApsNetCoreContext context) {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Empresa.Any())
            {
                return; // o bd já foi populado;
            }

            Department d1 = new Department() {Id = 1, Nome =  "Departamento1" };
            Department d2 = new Department(2, "Departamento2");

            ICollection<Department> departments = new List<Department>();
            departments.Add(d1); departments.Add(d2);

            Empresa e1 = new Empresa { Id = 1, Nome = "Empresa1", Departamentos = departments};

            _context.Department.AddRange(d1, d2);

            _context.Empresa.AddRange(e1);

            _context.SaveChanges();
        }
    }
}
