using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoComSenhaApi.Data;
using ProjetoComSenhaApi.Models;

namespace ProjetoComSenhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegioesController : ControllerBase
    {
        private readonly ProjetoComSenhaApiContext _context;

        public RegioesController(ProjetoComSenhaApiContext context)
        {
            _context = context;
        }

        // GET: api/Regioes
        [HttpGet]
        public IEnumerable<Regiao> GetRegiao()
        {
            return _context.Regiao;
        }

        // GET: api/Regioes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRegiao([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regiao = await _context.Regiao.FindAsync(id);

            if (regiao == null)
            {
                return NotFound();
            }

            return Ok(regiao);
        }

        // PUT: api/Regioes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegiao([FromRoute] int id, [FromBody] Regiao regiao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != regiao.RegiaoId)
            {
                return BadRequest();
            }

            _context.Entry(regiao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegiaoExists(id))
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

        // POST: api/Regioes
        [HttpPost]
        public async Task<IActionResult> PostRegiao([FromBody] Regiao regiao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Regiao.Add(regiao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegiao", new { id = regiao.RegiaoId }, regiao);
        }

        // DELETE: api/Regioes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegiao([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regiao = await _context.Regiao.FindAsync(id);
            if (regiao == null)
            {
                return NotFound();
            }

            _context.Regiao.Remove(regiao);
            await _context.SaveChangesAsync();

            return Ok(regiao);
        }

        private bool RegiaoExists(int id)
        {
            return _context.Regiao.Any(e => e.RegiaoId == id);
        }
    }
}