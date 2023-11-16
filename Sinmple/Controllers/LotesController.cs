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
<<<<<<< HEAD
            return View(await _context.Lote.ToListAsync());
        }

        // GET: Lotes/Details/5
        public async Task<IActionResult> Details(string id)
=======
              return _context.Lote != null ? 
                          View(await _context.Lote.ToListAsync()) :
                          Problem("Entity set 'SinmpleContext.Lote'  is null.");
        }

        // GET: Lotes/Details/5
        public async Task<IActionResult> Details(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Lote == null)
            {
                return NotFound();
            }

            var lote = await _context.Lote
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdLote == id);
=======
                .FirstOrDefaultAsync(m => m.Id_lote == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
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
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("IdLote,NombreLote,FechaElaboracion,FechaVencimiento,Cantidad,IdUsuario,IdProducto")] Lote lote)
=======
        public async Task<IActionResult> Create([Bind("Id_lote,Nombre_lote,FechaElaboracion,FechaVencimiento,Cantidad,Productos_id,Almacen_id,usuario_id")] Lote lote)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
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
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id)
=======
        public async Task<IActionResult> Edit(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
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
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id, [Bind("IdLote,NombreLote,FechaElaboracion,FechaVencimiento,Cantidad,IdUsuario,IdProducto")] Lote lote)
        {
            if (id != lote.IdLote)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id_lote,Nombre_lote,FechaElaboracion,FechaVencimiento,Cantidad,Productos_id,Almacen_id,usuario_id")] Lote lote)
        {
            if (id != lote.Id_lote)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
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
<<<<<<< HEAD
                    if (!LoteExists(lote.IdLote))
=======
                    if (!LoteExists(lote.Id_lote))
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
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
<<<<<<< HEAD
        public async Task<IActionResult> Delete(string id)
=======
        public async Task<IActionResult> Delete(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Lote == null)
            {
                return NotFound();
            }

            var lote = await _context.Lote
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdLote == id);
=======
                .FirstOrDefaultAsync(m => m.Id_lote == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (lote == null)
            {
                return NotFound();
            }

            return View(lote);
        }

        // POST: Lotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> DeleteConfirmed(string id)
=======
        public async Task<IActionResult> DeleteConfirmed(int id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
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
<<<<<<< HEAD

=======
            
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

<<<<<<< HEAD
        private bool LoteExists(string id)
        {
            return _context.Lote.Any(e => e.IdLote == id);
=======
        private bool LoteExists(int id)
        {
          return (_context.Lote?.Any(e => e.Id_lote == id)).GetValueOrDefault();
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        }
    }
}
