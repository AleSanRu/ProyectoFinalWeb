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
    public class MovimientosInventariosController : Controller
    {
        private readonly SinmpleContext _context;

        public MovimientosInventariosController(SinmpleContext context)
        {
            _context = context;
        }

        // GET: MovimientosInventarios
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            return View(await _context.MovimientosInventario.ToListAsync());
        }

        // GET: MovimientosInventarios/Details/5
        public async Task<IActionResult> Details(string id)
=======
              return _context.MovimientosInventario != null ? 
                          View(await _context.MovimientosInventario.ToListAsync()) :
                          Problem("Entity set 'SinmpleContext.MovimientosInventario'  is null.");
        }

        // GET: MovimientosInventarios/Details/5
        public async Task<IActionResult> Details(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.MovimientosInventario == null)
            {
                return NotFound();
            }

            var movimientosInventario = await _context.MovimientosInventario
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdMovimiento == id);
=======
                .FirstOrDefaultAsync(m => m.Id_movimiento == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (movimientosInventario == null)
            {
                return NotFound();
            }

            return View(movimientosInventario);
        }

        // GET: MovimientosInventarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MovimientosInventarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("IdMovimiento,Cantidad,TipoMovimiento,Fecha,Descripcion,IdLoteFk")] MovimientosInventario movimientosInventario)
=======
        public async Task<IActionResult> Create([Bind("Id_movimiento,Cantidad,TipoMovimiento,Fecha,id_lote")] MovimientosInventario movimientosInventario)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (ModelState.IsValid)
            {
                _context.Add(movimientosInventario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movimientosInventario);
        }

        // GET: MovimientosInventarios/Edit/5
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id)
=======
        public async Task<IActionResult> Edit(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.MovimientosInventario == null)
            {
                return NotFound();
            }

            var movimientosInventario = await _context.MovimientosInventario.FindAsync(id);
            if (movimientosInventario == null)
            {
                return NotFound();
            }
            return View(movimientosInventario);
        }

        // POST: MovimientosInventarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id, [Bind("IdMovimiento,Cantidad,TipoMovimiento,Fecha,Descripcion,IdLoteFk")] MovimientosInventario movimientosInventario)
        {
            if (id != movimientosInventario.IdMovimiento)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id_movimiento,Cantidad,TipoMovimiento,Fecha,id_lote")] MovimientosInventario movimientosInventario)
        {
            if (id != movimientosInventario.Id_movimiento)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movimientosInventario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
<<<<<<< HEAD
                    if (!MovimientosInventarioExists(movimientosInventario.IdMovimiento))
=======
                    if (!MovimientosInventarioExists(movimientosInventario.Id_movimiento))
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
            return View(movimientosInventario);
        }

        // GET: MovimientosInventarios/Delete/5
<<<<<<< HEAD
        public async Task<IActionResult> Delete(string id)
=======
        public async Task<IActionResult> Delete(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.MovimientosInventario == null)
            {
                return NotFound();
            }

            var movimientosInventario = await _context.MovimientosInventario
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdMovimiento == id);
=======
                .FirstOrDefaultAsync(m => m.Id_movimiento == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (movimientosInventario == null)
            {
                return NotFound();
            }

            return View(movimientosInventario);
        }

        // POST: MovimientosInventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> DeleteConfirmed(string id)
=======
        public async Task<IActionResult> DeleteConfirmed(int id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (_context.MovimientosInventario == null)
            {
                return Problem("Entity set 'SinmpleContext.MovimientosInventario'  is null.");
            }
            var movimientosInventario = await _context.MovimientosInventario.FindAsync(id);
            if (movimientosInventario != null)
            {
                _context.MovimientosInventario.Remove(movimientosInventario);
            }
<<<<<<< HEAD

=======
            
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

<<<<<<< HEAD
        private bool MovimientosInventarioExists(string id)
        {
            return _context.MovimientosInventario.Any(e => e.IdMovimiento == id);
=======
        private bool MovimientosInventarioExists(int id)
        {
          return (_context.MovimientosInventario?.Any(e => e.Id_movimiento == id)).GetValueOrDefault();
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        }
    }
}
