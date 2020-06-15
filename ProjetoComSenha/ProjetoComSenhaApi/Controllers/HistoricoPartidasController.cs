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
    public class HistoricoPartidasController : ControllerBase
    {
        private readonly ProjetoComSenhaApiContext _context;

        public HistoricoPartidasController(ProjetoComSenhaApiContext context)
        {
            _context = context;
        }

        // GET: api/HistoricoPartidas
        [HttpGet]
        public IEnumerable<HistoricoPartida> GetHistoricoPartida()
        {
            return _context.HistoricoPartida;
        }

        // GET: api/HistoricoPartidas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistoricoPartida([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historicoPartida = await _context.HistoricoPartida.FindAsync(id);

            if (historicoPartida == null)
            {
                return NotFound();
            }

            return Ok(historicoPartida);
        }

        // PUT: api/HistoricoPartidas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoricoPartida([FromRoute] int id, [FromBody] HistoricoPartida historicoPartida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != historicoPartida.HistoricoPartidaId)
            {
                return BadRequest();
            }

            _context.Entry(historicoPartida).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoricoPartidaExists(id))
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

        // POST: api/HistoricoPartidas
        [HttpPost]
        public async Task<IActionResult> PostHistoricoPartida([FromBody] HistoricoPartida historicoPartida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HistoricoPartida.Add(historicoPartida);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistoricoPartida", new { id = historicoPartida.HistoricoPartidaId }, historicoPartida);
        }

        // DELETE: api/HistoricoPartidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoricoPartida([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historicoPartida = await _context.HistoricoPartida.FindAsync(id);
            if (historicoPartida == null)
            {
                return NotFound();
            }

            _context.HistoricoPartida.Remove(historicoPartida);
            await _context.SaveChangesAsync();

            return Ok(historicoPartida);
        }

        private bool HistoricoPartidaExists(int id)
        {
            return _context.HistoricoPartida.Any(e => e.HistoricoPartidaId == id);
        }
    }
}