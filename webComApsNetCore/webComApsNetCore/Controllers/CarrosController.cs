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
    [Route("api/[Controller]")]
    [ApiController]
    public class CarrosController : Controller
    {
        private readonly webComApsNetCoreContext _context;

        public CarrosController(webComApsNetCoreContext context)
        {
            _context = context;
        }

        // GET: api/Carros
        [HttpGet("index")]
        public async Task<IActionResult> Index(int id)
        {
            return View(await _context.Carro.ToListAsync());
        }

        // GET: Carros/Details/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = await _context.Carro
                .FirstOrDefaultAsync(m => m.id == id);
            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        // GET: Carros/Create
        [HttpGet("create")]
        public  IActionResult Create(DateTime? minDate, DateTime? maxDate, string nome)
        {
            List<CarroGenerico> listaGenerica = new List<CarroGenerico>();
            List<string> exProprietarios = new List<string> { "João", "Maria", "Tobias", "Júlia" };

            CarroGenerico carroGenerico = new CarroGenerico();
            carroGenerico.Cor = "Azul";
            carroGenerico.Placa = "MGC-0050";
            carroGenerico.Proprietario = "Carlos Doido Varrido";
            carroGenerico.exProprietarios = exProprietarios;

            listaGenerica.Add(carroGenerico);

            CarroGenerico carroGenerico2 = new CarroGenerico();
            carroGenerico2.Cor = "Branco";
            carroGenerico2.Placa = "MGC-0130";
            carroGenerico2.Proprietario = "Sonia Candico";
            carroGenerico2.exProprietarios = exProprietarios;

            listaGenerica.Add(carroGenerico2);

            CarroGenerico carroGenerico3 = new CarroGenerico();
            carroGenerico3.Cor = "Preto";
            carroGenerico3.Placa = "MGC-2020";
            carroGenerico3.Proprietario = "Goku";
            carroGenerico3.exProprietarios = exProprietarios;

            listaGenerica.Add(carroGenerico3);

            List<CarroGenerico> novaLista = new List<CarroGenerico>();

            if (nome != null)
            {
                novaLista.Add(listaGenerica.Where(x => x.Cor.ToUpper().Contains(nome.ToUpper())).SingleOrDefault());
            }
            else
            {
                novaLista = listaGenerica;
            }

            ViewBag.MyList = novaLista;

            return View();
        }

        // GET: Carros/Create
        [HttpGet("lista")]
        public async Task<ActionResult<IEnumerable<CarroGenerico>>> Lista()
        {
            string nome;
            List<CarroGenerico> listaGenerica = new List<CarroGenerico>();
            List<string> exProprietarios = new List<string> { "João", "Maria", "Tobias", "Júlia" };

            CarroGenerico carroGenerico = new CarroGenerico();
            carroGenerico.Cor = "Azul";
            carroGenerico.Placa = "MGC-0050";
            carroGenerico.Proprietario = "Carlos Doido Varrido";
            carroGenerico.exProprietarios = exProprietarios;

            listaGenerica.Add(carroGenerico);

            CarroGenerico carroGenerico2 = new CarroGenerico();
            carroGenerico2.Cor = "Branco";
            carroGenerico2.Placa = "MGC-0130";
            carroGenerico2.Proprietario = "Sonia Candico";
            carroGenerico2.exProprietarios = exProprietarios;

            listaGenerica.Add(carroGenerico2);

            CarroGenerico carroGenerico3 = new CarroGenerico();
            carroGenerico3.Cor = "Preto";
            carroGenerico3.Placa = "MGC-2020";
            carroGenerico3.Proprietario = "Goku";
            carroGenerico3.exProprietarios = exProprietarios;

            listaGenerica.Add(carroGenerico3);

            List<CarroGenerico> novaLista = new List<CarroGenerico>();

            //if (nome != null)
            //{
            //    novaLista.Add(listaGenerica.Where(x => x.Cor.ToUpper().Contains(nome.ToUpper())).SingleOrDefault());
            //}
            //else
            //{
            //    novaLista = listaGenerica;
            //}

            novaLista = listaGenerica;

            return Ok(novaLista);
        }

        public struct CarroGenerico
        {
            public string Cor;
            public string Placa;
            public string Proprietario;
            public List<string> exProprietarios;
        }

        // POST: Carros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,placa,cor")] Carro carro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carro);
        }

        // GET: Carros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = await _context.Carro.FindAsync(id);
            if (carro == null)
            {
                return NotFound();
            }
            return View(carro);
        }

        // POST: Carros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,placa,cor")] Carro carro)
        {
            if (id != carro.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarroExists(carro.id))
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
            return View(carro);
        }

        // GET: Carros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = await _context.Carro
                .FirstOrDefaultAsync(m => m.id == id);
            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        // POST: Carros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carro = await _context.Carro.FindAsync(id);
            _context.Carro.Remove(carro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarroExists(int id)
        {
            return _context.Carro.Any(e => e.id == id);
        }
    }
}
