using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webComApsNetCore.Data;
using webComApsNetCore.Models;

namespace webComApsNetCore.Controllers
{
    public class CategoriaLivrosController : Controller
    {
        private readonly webComApsNetCoreContext _context;

        public CategoriaLivrosController(webComApsNetCoreContext context)
        {
            _context = context;
        }

        // GET: CategoriaLivros
        public async Task<IActionResult> Index()
        {
            var result = from obj in _context.Categoria select obj;

            List<Desempenho> desempenhos = new List<Desempenho>();

            Desempenho desempenho = new Desempenho();

            desempenho.CoSeqCategoriaAvaliacao = 1;
            desempenho.desempenhoMes = 20;
            desempenho.mes = 3;
            desempenhos.Add(desempenho);

            desempenho.CoSeqCategoriaAvaliacao = 3;
            desempenho.desempenhoMes = 20;
            desempenho.mes = 4;
            desempenhos.Add(desempenho);

            desempenho.CoSeqCategoriaAvaliacao = 3;
            desempenho.desempenhoMes = 20;
            desempenho.mes = 3;
            desempenhos.Add(desempenho);

            desempenho.CoSeqCategoriaAvaliacao = 2;
            desempenho.desempenhoMes = 20;
            desempenho.mes = 4;
            desempenhos.Add(desempenho);

            desempenho.CoSeqCategoriaAvaliacao = 3;
            desempenho.desempenhoMes = 50;
            desempenho.mes = 3;
            desempenhos.Add(desempenho);

            var nova = desempenhos.OrderBy(d1 => d1.CoSeqCategoriaAvaliacao).ThenBy(d1 => d1.mes);

            int sum = nova.Aggregate(0, (d1, d2) => d2.mes == 3 && d2.CoSeqCategoriaAvaliacao == 3 ? d2.mes : d2.mes);

            foreach (Desempenho d in nova)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine(sum);

            desempenhos.ForEach(p => { p.mes += p.mes + 5; });

            foreach (Desempenho p in desempenhos)
            {
                var w = p.mes;
            }

            List<double> listaFloat = new List<double>();

            for (int mes=1; mes<=4; mes++)
            {
                for (int categoria=1; categoria<=3; categoria++)
                {
                    listaFloat.Add(desempenhos.Where(p => p.CoSeqCategoriaAvaliacao == categoria && p.mes == mes).Sum(p => p.desempenhoMes));
                }
            }

            for (int mes = 1; mes <= 4; mes++)
            {
                for (int categoria = 1; categoria <= 3; categoria++)
                {
                    listaFloat.Add(desempenhos.Where(p => p.CoSeqCategoriaAvaliacao == categoria && p.mes == mes).Select(p => p.desempenhoMes).DefaultIfEmpty(0).Average());
                }
            }

            for (int mes = 1; mes <= 4; mes++)
            {
                for (int categoria = 1; categoria <= 3; categoria++)
                {
                    listaFloat.Add(desempenhos.Where(p => p.CoSeqCategoriaAvaliacao == categoria && p.mes == mes).Select(p => p.desempenhoMes).Aggregate(0.0, (x , y) => x + y));
                }
            }

            foreach (float f in listaFloat)
            {
                Console.WriteLine(f);
            }

            var r1 = desempenhos.GroupBy(p => p.CoSeqCategoriaAvaliacao);

            foreach (IGrouping<int, Desempenho> grupo in r1)
            {
                Console.WriteLine("Categoria: " + grupo.Key);
                foreach (Desempenho d1 in grupo)
                {
                    Console.WriteLine(grupo);
                }
            }

            return View(await result.ToListAsync());
        }

        // GET: CategoriaLivros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaLivro = await _context.Categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaLivro == null)
            {
                return NotFound();
            }

            return View(categoriaLivro);
        }

        // GET: CategoriaLivros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaLivros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] CategoriaLivro categoriaLivro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaLivro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaLivro);
        }

        // GET: CategoriaLivros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaLivro = await _context.Categoria.FindAsync(id);
            if (categoriaLivro == null)
            {
                return NotFound();
            }
            return View(categoriaLivro);
        }

        // POST: CategoriaLivros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] CategoriaLivro categoriaLivro)
        {
            if (id != categoriaLivro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaLivro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaLivroExists(categoriaLivro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaLivro);
        }

        // GET: CategoriaLivros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaLivro = await _context.Categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaLivro == null)
            {
                return NotFound();
            }

            return View(categoriaLivro);
        }

        // POST: CategoriaLivros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaLivro = await _context.Categoria.FindAsync(id);
            _context.Categoria.Remove(categoriaLivro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaLivroExists(int id)
        {
            return _context.Categoria.Any(e => e.Id == id);
        }

        struct Desempenho { public int CoSeqCategoriaAvaliacao { get; set; } 
            public float desempenhoMes { get; set; } 
            public int mes { get; set; } 
            public string nome { get; set; } 
        };
    }
}
