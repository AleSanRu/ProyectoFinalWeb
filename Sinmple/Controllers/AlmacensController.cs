using System;
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
    public class AlmacensController : Controller
    {
        private readonly SinmpleContext _context;

        public AlmacensController(SinmpleContext context)
        {
            _context = context;
        }

        // GET: Almacens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Almacen.ToListAsync());
        }

        // GET: Almacens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Almacen == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .FirstOrDefaultAsync(m => m.IdAlmacen == id);
            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        // GET: Almacens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Almacens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAlmacen,Nombre,Ubicacion")] Almacen almacen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(almacen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(almacen);
        }

        // GET: Almacens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Almacen == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen.FindAsync(id);
            if (almacen == null)
            {
                return NotFound();
            }
            return View(almacen);
        }

        // POST: Almacens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdAlmacen,Nombre,Ubicacion")] Almacen almacen)
        {
            if (id != almacen.IdAlmacen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(almacen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlmacenExists(almacen.IdAlmacen))
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
            return View(almacen);
        }

        // GET: Almacens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Almacen == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .FirstOrDefaultAsync(m => m.IdAlmacen == id);
            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        // POST: Almacens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Almacen == null)
            {
                return Problem("Entity set 'SinmpleContext.Almacen'  is null.");
            }
            var almacen = await _context.Almacen.FindAsync(id);
            if (almacen != null)
            {
                _context.Almacen.Remove(almacen);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlmacenExists(string id)
        {
            return _context.Almacen.Any(e => e.IdAlmacen == id);
        }
    }
}
