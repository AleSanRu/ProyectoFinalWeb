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
    public class CuentasController : Controller
    {
        private readonly SinmpleContext _context;

        public CuentasController(SinmpleContext context)
        {
            _context = context;
        }

        // GET: Cuentas
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            return View(await _context.Cuenta.ToListAsync());
        }

        // GET: Cuentas/Details/5
        public async Task<IActionResult> Details(string id)
=======
              return _context.Cuenta != null ? 
                          View(await _context.Cuenta.ToListAsync()) :
                          Problem("Entity set 'SinmpleContext.Cuenta'  is null.");
        }

        // GET: Cuentas/Details/5
        public async Task<IActionResult> Details(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Cuenta == null)
            {
                return NotFound();
            }

            var cuenta = await _context.Cuenta
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdCuenta == id);
=======
                .FirstOrDefaultAsync(m => m.Id_cuenta == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (cuenta == null)
            {
                return NotFound();
            }

            return View(cuenta);
        }

        // GET: Cuentas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cuentas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("IdCuenta,Usuario,Contraseña,IdUsuario")] Cuenta cuenta)
=======
        public async Task<IActionResult> Create([Bind("Id_cuenta,Usuario,Contraseña")] Cuenta cuenta)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cuenta);
        }

        // GET: Cuentas/Edit/5
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id)
=======
        public async Task<IActionResult> Edit(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Cuenta == null)
            {
                return NotFound();
            }

            var cuenta = await _context.Cuenta.FindAsync(id);
            if (cuenta == null)
            {
                return NotFound();
            }
            return View(cuenta);
        }

        // POST: Cuentas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id, [Bind("IdCuenta,Usuario,Contraseña,IdUsuario")] Cuenta cuenta)
        {
            if (id != cuenta.IdCuenta)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id_cuenta,Usuario,Contraseña")] Cuenta cuenta)
        {
            if (id != cuenta.Id_cuenta)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
<<<<<<< HEAD
                    if (!CuentaExists(cuenta.IdCuenta))
=======
                    if (!CuentaExists(cuenta.Id_cuenta))
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
            return View(cuenta);
        }

        // GET: Cuentas/Delete/5
<<<<<<< HEAD
        public async Task<IActionResult> Delete(string id)
=======
        public async Task<IActionResult> Delete(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Cuenta == null)
            {
                return NotFound();
            }

            var cuenta = await _context.Cuenta
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdCuenta == id);
=======
                .FirstOrDefaultAsync(m => m.Id_cuenta == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (cuenta == null)
            {
                return NotFound();
            }

            return View(cuenta);
        }

        // POST: Cuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> DeleteConfirmed(string id)
=======
        public async Task<IActionResult> DeleteConfirmed(int id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (_context.Cuenta == null)
            {
                return Problem("Entity set 'SinmpleContext.Cuenta'  is null.");
            }
            var cuenta = await _context.Cuenta.FindAsync(id);
            if (cuenta != null)
            {
                _context.Cuenta.Remove(cuenta);
            }
<<<<<<< HEAD

=======
            
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

<<<<<<< HEAD
        private bool CuentaExists(string id)
        {
            return _context.Cuenta.Any(e => e.IdCuenta == id);
=======
        private bool CuentaExists(int id)
        {
          return (_context.Cuenta?.Any(e => e.Id_cuenta == id)).GetValueOrDefault();
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        }
    }
}
