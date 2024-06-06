﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;

namespace Inscripciones.Controllers
{
    public class InscripcionesController : Controller
    {
        private readonly InscripcionesContext _context;

        public InscripcionesController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: Inscripciones
        public async Task<IActionResult> Index()
        {
            var inscripcionesContext = _context.inscripciones.Include(i => i.Alumno).Include(i => i.Carrera);
            return View(await inscripcionesContext.ToListAsync());
        }

        // GET: Inscripciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.inscripciones
                .Include(i => i.Alumno)
                .Include(i => i.Carrera)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscripcion == null)
            {
                return NotFound();
            }

            return View(inscripcion);
        }

        // GET: Inscripciones/Create
        public IActionResult Create()
        {
            ViewData["AlumnoId"] = new SelectList(_context.alumnos, "Id", "Id");
            ViewData["CarreraId"] = new SelectList(_context.carreras, "id", "id");
            return View();
        }

        // POST: Inscripciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,AlumnoId,CarreraId")] Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inscripcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoId"] = new SelectList(_context.alumnos, "Id", "Id", inscripcion.AlumnoId);
            ViewData["CarreraId"] = new SelectList(_context.carreras, "id", "id", inscripcion.CarreraId);
            return View(inscripcion);
        }

        // GET: Inscripciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.inscripciones.FindAsync(id);
            if (inscripcion == null)
            {
                return NotFound();
            }
            ViewData["AlumnoId"] = new SelectList(_context.alumnos, "Id", "Id", inscripcion.AlumnoId);
            ViewData["CarreraId"] = new SelectList(_context.carreras, "id", "id", inscripcion.CarreraId);
            return View(inscripcion);
        }

        // POST: Inscripciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,AlumnoId,CarreraId")] Inscripcion inscripcion)
        {
            if (id != inscripcion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inscripcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InscripcionExists(inscripcion.Id))
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
            ViewData["AlumnoId"] = new SelectList(_context.alumnos, "Id", "Id", inscripcion.AlumnoId);
            ViewData["CarreraId"] = new SelectList(_context.carreras, "id", "id", inscripcion.CarreraId);
            return View(inscripcion);
        }

        // GET: Inscripciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await _context.inscripciones
                .Include(i => i.Alumno)
                .Include(i => i.Carrera)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inscripcion == null)
            {
                return NotFound();
            }

            return View(inscripcion);
        }

        // POST: Inscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inscripcion = await _context.inscripciones.FindAsync(id);
            if (inscripcion != null)
            {
                _context.inscripciones.Remove(inscripcion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InscripcionExists(int id)
        {
            return _context.inscripciones.Any(e => e.Id == id);
        }
    }
}
