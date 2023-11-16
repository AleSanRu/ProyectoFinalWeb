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
            return View(await _context.Cuenta.ToListAsync());
        }

        // GET: Cuentas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Cuenta == null)
            {
                return NotFound();
            }

            var cuenta = await _context.Cuenta
                .FirstOrDefaultAsync(m => m.IdCuenta == id);
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
        public async Task<IActionResult> Create([Bind("IdCuenta,Usuario,Contraseña,IdUsuario")] Cuenta cuenta)
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
        public async Task<IActionResult> Edit(string id)
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
        public async Task<IActionResult> Edit(string id, [Bind("IdCuenta,Usuario,Contraseña,IdUsuario")] Cuenta cuenta)
        {
            if (id != cuenta.IdCuenta)
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
                    if (!CuentaExists(cuenta.IdCuenta))
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
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Cuenta == null)
            {
                return NotFound();
            }

            var cuenta = await _context.Cuenta
                .FirstOrDefaultAsync(m => m.IdCuenta == id);
            if (cuenta == null)
            {
                return NotFound();
            }

            return View(cuenta);
        }

        // POST: Cuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
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

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuentaExists(string id)
        {
            return _context.Cuenta.Any(e => e.IdCuenta == id);
        }
    }
}
