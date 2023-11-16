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
    public class ProductoesController : Controller
    {
        private readonly SinmpleContext _context;

        public ProductoesController(SinmpleContext context)
        {
            _context = context;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            return View(await _context.Producto.ToListAsync());
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(string id)
=======
              return _context.Producto != null ? 
                          View(await _context.Producto.ToListAsync()) :
                          Problem("Entity set 'SinmpleContext.Producto'  is null.");
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdProducto == id);
=======
                .FirstOrDefaultAsync(m => m.Productos_id == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("IdProducto,Nombre,Tipo")] Producto producto)
=======
        public async Task<IActionResult> Create([Bind("Productos_id,Nombre,tipo")] Producto producto)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productoes/Edit/5
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id)
=======
        public async Task<IActionResult> Edit(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id, [Bind("IdProducto,Nombre,Tipo")] Producto producto)
        {
            if (id != producto.IdProducto)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Productos_id,Nombre,tipo")] Producto producto)
        {
            if (id != producto.Productos_id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
<<<<<<< HEAD
                    if (!ProductoExists(producto.IdProducto))
=======
                    if (!ProductoExists(producto.Productos_id))
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
            return View(producto);
        }

        // GET: Productoes/Delete/5
<<<<<<< HEAD
        public async Task<IActionResult> Delete(string id)
=======
        public async Task<IActionResult> Delete(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdProducto == id);
=======
                .FirstOrDefaultAsync(m => m.Productos_id == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> DeleteConfirmed(string id)
=======
        public async Task<IActionResult> DeleteConfirmed(int id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (_context.Producto == null)
            {
                return Problem("Entity set 'SinmpleContext.Producto'  is null.");
            }
            var producto = await _context.Producto.FindAsync(id);
            if (producto != null)
            {
                _context.Producto.Remove(producto);
            }
<<<<<<< HEAD

=======
            
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

<<<<<<< HEAD
        private bool ProductoExists(string id)
        {
            return _context.Producto.Any(e => e.IdProducto == id);
=======
        private bool ProductoExists(int id)
        {
          return (_context.Producto?.Any(e => e.Productos_id == id)).GetValueOrDefault();
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        }
    }
}
