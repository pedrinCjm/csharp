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
    public class TipoJogosController : ControllerBase
    {
        private readonly ProjetoComSenhaApiContext _context;

        public TipoJogosController(ProjetoComSenhaApiContext context)
        {
            _context = context;
        }

        // GET: api/TipoJogos
        [HttpGet]
        public IEnumerable<TipoJogo> GetTipoJogo()
        {
            return _context.TipoJogo;
        }

        // GET: api/TipoJogos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoJogo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoJogo = await _context.TipoJogo.FindAsync(id);

            if (tipoJogo == null)
            {
                return NotFound();
            }

            return Ok(tipoJogo);
        }

        // PUT: api/TipoJogos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoJogo([FromRoute] int id, [FromBody] TipoJogo tipoJogo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoJogo.TipoJogoId)
            {
                return BadRequest();
            }

            _context.Entry(tipoJogo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoJogoExists(id))
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

        // POST: api/TipoJogos
        [HttpPost]
        public async Task<IActionResult> PostTipoJogo([FromBody] TipoJogo tipoJogo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TipoJogo.Add(tipoJogo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoJogo", new { id = tipoJogo.TipoJogoId }, tipoJogo);
        }

        // DELETE: api/TipoJogos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoJogo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoJogo = await _context.TipoJogo.FindAsync(id);
            if (tipoJogo == null)
            {
                return NotFound();
            }

            _context.TipoJogo.Remove(tipoJogo);
            await _context.SaveChangesAsync();

            return Ok(tipoJogo);
        }

        private bool TipoJogoExists(int id)
        {
            return _context.TipoJogo.Any(e => e.TipoJogoId == id);
        }
    }
}