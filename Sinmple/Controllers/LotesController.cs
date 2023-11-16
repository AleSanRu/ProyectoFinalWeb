﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sinmple.Data;
using Sinmple.Models;

namespace Sinmple.Controllers
{
    public class LotesController : Controller
    {
        private readonly SinmpleContext _context;

        public LotesController(SinmpleContext context)
        {
            _context = context;
        }

        // GET: Lotes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lote.ToListAsync());
        }

        // GET: Lotes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Lote == null)
            {
                return NotFound();
            }

            var lote = await _context.Lote
                .FirstOrDefaultAsync(m => m.IdLote == id);
            if (lote == null)
            {
                return NotFound();
            }

            return View(lote);
        }

        // GET: Lotes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLote,NombreLote,FechaElaboracion,FechaVencimiento,Cantidad,IdUsuario,IdProducto")] Lote lote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lote);
        }

        // GET: Lotes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Lote == null)
            {
                return NotFound();
            }

            var lote = await _context.Lote.FindAsync(id);
            if (lote == null)
            {
                return NotFound();
            }
            return View(lote);
        }

        // POST: Lotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdLote,NombreLote,FechaElaboracion,FechaVencimiento,Cantidad,IdUsuario,IdProducto")] Lote lote)
        {
            if (id != lote.IdLote)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoteExists(lote.IdLote))
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
            return View(lote);
        }

        // GET: Lotes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Lote == null)
            {
                return NotFound();
            }

            var lote = await _context.Lote
                .FirstOrDefaultAsync(m => m.IdLote == id);
            if (lote == null)
            {
                return NotFound();
            }

            return View(lote);
        }

        // POST: Lotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Lote == null)
            {
                return Problem("Entity set 'SinmpleContext.Lote'  is null.");
            }
            var lote = await _context.Lote.FindAsync(id);
            if (lote != null)
            {
                _context.Lote.Remove(lote);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoteExists(string id)
        {
            return _context.Lote.Any(e => e.IdLote == id);
        }
    }
}
