using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoComSenhaApi.Data;
using ProjetoComSenhaApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoComSenhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        private readonly ProjetoComSenhaApiContext _context;

        public JogosController(ProjetoComSenhaApiContext context)
        {
            _context = context;
        }

        // GET: api/Jogos
        [HttpGet]
        public async Task<IActionResult> GetJogo()
        {
            //var result = from obj in _context.Jogo select obj;

            //return Ok(await result.Include(x => x.TipoJogo).ToListAsync());

            var result = await _context.Jogo
                .Select(dados => new
                {
                    dados.JogoId,
                    dados.DsJogo,
                    dados.NoJogo,
                    dados.TipoJogoId,
                    dados.TipoJogo,
                    JogadoresRegistrados = 350,
                    JogadoresOnline = 99,
                    CodigoPromocional = "COD30"
                })
                .ToListAsync();

            return Ok(result);
        }

        // GET: api/Jogos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJogo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jogo = await _context.Jogo.FindAsync(id);

            if (jogo == null)
            {
                return NotFound();
            }

            return Ok(jogo);
        }

        // PUT: api/Jogos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJogo([FromRoute] int id, [FromBody] Jogo jogo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jogo.JogoId)
            {
                return BadRequest();
            }

            _context.Entry(jogo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JogoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Jogos
        [HttpPost]
        public async Task<IActionResult> PostJogo([FromBody] Jogo jogo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Jogo.Add(jogo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJogo", new { id = jogo.JogoId }, jogo);
        }

        // DELETE: api/Jogos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJogo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jogo = await _context.Jogo.FindAsync(id);
            if (jogo == null)
            {
                return NotFound();
            }

            _context.Jogo.Remove(jogo);
            await _context.SaveChangesAsync();

            return Ok(jogo);
        }

        private bool JogoExists(int id)
        {
            return _context.Jogo.Any(e => e.JogoId == id);
        }
    }
}