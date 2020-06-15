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
    public class PartidasController : ControllerBase
    {
        private readonly ProjetoComSenhaApiContext _context;

        public PartidasController(ProjetoComSenhaApiContext context)
        {
            _context = context;
        }

        // GET: api/Partidas
        [HttpGet]
        public IEnumerable<Partida> GetPartida()
        {
            return _context.Partida;
        }

        // GET: api/Partidas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPartida([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var partida = await _context.Partida.FindAsync(id);

            if (partida == null)
            {
                return NotFound();
            }

            return Ok(partida);
        }

        // PUT: api/Partidas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartida([FromRoute] int id, [FromBody] Partida partida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != partida.PartidaId)
            {
                return BadRequest();
            }

            _context.Entry(partida).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartidaExists(id))
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

        // POST: api/Partidas
        [HttpPost]
        public async Task<IActionResult> PostPartida([FromBody] Partida partida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Partida.Add(partida);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPartida", new { id = partida.PartidaId }, partida);
        }

        // DELETE: api/Partidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePartida([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var partida = await _context.Partida.FindAsync(id);
            if (partida == null)
            {
                return NotFound();
            }

            _context.Partida.Remove(partida);
            await _context.SaveChangesAsync();

            return Ok(partida);
        }

        private bool PartidaExists(int id)
        {
            return _context.Partida.Any(e => e.PartidaId == id);
        }
    }
}