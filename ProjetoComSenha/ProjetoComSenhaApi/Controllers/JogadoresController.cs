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
    public class JogadoresController : ControllerBase
    {
        private readonly ProjetoComSenhaApiContext _context;

        public JogadoresController(ProjetoComSenhaApiContext context)
        {
            _context = context;
        }

        // GET: api/Jogadores
        [HttpGet]
        public IEnumerable<Jogador> GetJogador()
        {
            return _context.Jogador;
        }

        // GET: api/Jogadores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJogador([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jogador = await _context.Jogador.FindAsync(id);

            if (jogador == null)
            {
                return NotFound();
            }

            return Ok(jogador);
        }

        // PUT: api/Jogadores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJogador([FromRoute] int id, [FromBody] Jogador jogador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jogador.JogadorId)
            {
                return BadRequest();
            }

            _context.Entry(jogador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JogadorExists(id))
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

        // POST: api/Jogadores
        [HttpPost]
        public async Task<IActionResult> PostJogador([FromBody] Jogador jogador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Jogador.Add(jogador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJogador", new { id = jogador.JogadorId }, jogador);
        }

        // DELETE: api/Jogadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJogador([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var jogador = await _context.Jogador.FindAsync(id);
            if (jogador == null)
            {
                return NotFound();
            }

            _context.Jogador.Remove(jogador);
            await _context.SaveChangesAsync();

            return Ok(jogador);
        }

        private bool JogadorExists(int id)
        {
            return _context.Jogador.Any(e => e.JogadorId == id);
        }
    }
}