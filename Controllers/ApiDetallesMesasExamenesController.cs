﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;

namespace Inscripciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDetallesMesasExamenesController : ControllerBase
    {
        private readonly InscripcionesContext _context;

        public ApiDetallesMesasExamenesController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: api/ApiDetallesMesasExamenes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleMesaExamen>>> Getdetallesmesasexamenes()
        {
            return await _context.detallesmesasexamenes.ToListAsync();
        }

        // GET: api/ApiDetallesMesasExamenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleMesaExamen>> GetDetalleMesaExamen(int id)
        {
            var detalleMesaExamen = await _context.detallesmesasexamenes.FindAsync(id);

            if (detalleMesaExamen == null)
            {
                return NotFound();
            }

            return detalleMesaExamen;
        }

        // PUT: api/ApiDetallesMesasExamenes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleMesaExamen(int id, DetalleMesaExamen detalleMesaExamen)
        {
            if (id != detalleMesaExamen.Id)
            {
                return BadRequest();
            }

            _context.Entry(detalleMesaExamen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleMesaExamenExists(id))
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

        // POST: api/ApiDetallesMesasExamenes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleMesaExamen>> PostDetalleMesaExamen(DetalleMesaExamen detalleMesaExamen)
        {
            _context.detallesmesasexamenes.Add(detalleMesaExamen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleMesaExamen", new { id = detalleMesaExamen.Id }, detalleMesaExamen);
        }

        // DELETE: api/ApiDetallesMesasExamenes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleMesaExamen(int id)
        {
            var detalleMesaExamen = await _context.detallesmesasexamenes.FindAsync(id);
            if (detalleMesaExamen == null)
            {
                return NotFound();
            }

            _context.detallesmesasexamenes.Remove(detalleMesaExamen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleMesaExamenExists(int id)
        {
            return _context.detallesmesasexamenes.Any(e => e.Id == id);
        }
    }
}
