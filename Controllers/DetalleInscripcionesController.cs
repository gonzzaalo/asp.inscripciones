using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;

namespace Inscripciones.Controllers
{
    public class DetalleInscripcionesController : Controller
    {
        private readonly InscripcionesContext _context;

        public DetalleInscripcionesController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: DetalleInscripciones
        public async Task<IActionResult> Index()
        {
            var inscripcionesContext = await _context.DetalleInscripcions.Include(d => d.Inscripcion).ThenInclude(i => i.Alumno).Include(d => d.Materia).ToListAsync();


            return View( inscripcionesContext);
        }

        // GET: DetalleInscripciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleInscripcion = await _context.DetalleInscripcions
                .Include(d => d.Inscripcion)
                .Include(d => d.Materia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleInscripcion == null)
            {
                return NotFound();
            }

            return View(detalleInscripcion);
        }

        // GET: DetalleInscripciones/Create
        public IActionResult Create()
        {
            ViewData["Inscripciones"] = new SelectList(_context.Inscripciones.Include(i=>i.Alumno), "Id", "Inscripto");
            ViewData["Materias"] = new SelectList(_context.Materias, "Id", "Nombre");
            return View();
        }

        // POST: DetalleInscripciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModalidadCursado,InscripcionId,MateriaId")] DetalleInscripcion detalleInscripcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleInscripcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InscripcionId"] = new SelectList(_context.Inscripciones, "Id", "Id", detalleInscripcion.InscripcionId);
            ViewData["MateriaId"] = new SelectList(_context.Materias, "Id", "Nombre", detalleInscripcion.MateriaId);
            return View(detalleInscripcion);
        }

        // GET: DetalleInscripciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleInscripcion = await _context.DetalleInscripcions.FindAsync(id);
            if (detalleInscripcion == null)
            {
                return NotFound();
            }
            ViewData["InscripcionId"] = new SelectList(_context.Inscripciones, "Id", "Id", detalleInscripcion.InscripcionId);
            ViewData["MateriaId"] = new SelectList(_context.Materias, "Id", "Nombre", detalleInscripcion.MateriaId);
            return View(detalleInscripcion);
        }

        // POST: DetalleInscripciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModalidadCursado,InscripcionId,MateriaId")] DetalleInscripcion detalleInscripcion)
        {
            if (id != detalleInscripcion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleInscripcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleInscripcionExists(detalleInscripcion.Id))
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
            ViewData["InscripcionId"] = new SelectList(_context.Inscripciones, "Id", "Id", detalleInscripcion.InscripcionId);
            ViewData["MateriaId"] = new SelectList(_context.Materias, "Id", "Nombre", detalleInscripcion.MateriaId);
            return View(detalleInscripcion);
        }

        // GET: DetalleInscripciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleInscripcion = await _context.DetalleInscripcions
                .Include(d => d.Inscripcion)
                .Include(d => d.Materia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleInscripcion == null)
            {
                return NotFound();
            }

            return View(detalleInscripcion);
        }

        // POST: DetalleInscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleInscripcion = await _context.DetalleInscripcions.FindAsync(id);
            if (detalleInscripcion != null)
            {
                _context.DetalleInscripcions.Remove(detalleInscripcion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleInscripcionExists(int id)
        {
            return _context.DetalleInscripcions.Any(e => e.Id == id);
        }
    }
}
