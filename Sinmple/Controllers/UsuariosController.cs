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
    public class UsuariosController : Controller
    {
        private readonly SinmpleContext _context;

        public UsuariosController(SinmpleContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            return View(await _context.Usuario.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(string id)
=======
              return _context.Usuario != null ? 
                          View(await _context.Usuario.ToListAsync()) :
                          Problem("Entity set 'SinmpleContext.Usuario'  is null.");
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
=======
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("IdUsuario,Nombre,Apellido,Email,Direccion,Cargo")] Usuario usuario)
=======
        public async Task<IActionResult> Create([Bind("Id_usuario,Nombre,Apellido,Correo,Direccion,Roles")] Usuario usuario)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id)
=======
        public async Task<IActionResult> Edit(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(string id, [Bind("IdUsuario,Nombre,Apellido,Email,Direccion,Cargo")] Usuario usuario)
        {
            if (id != usuario.IdUsuario)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id_usuario,Nombre,Apellido,Correo,Direccion,Roles")] Usuario usuario)
        {
            if (id != usuario.Id_usuario)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
<<<<<<< HEAD
                    if (!UsuarioExists(usuario.IdUsuario))
=======
                    if (!UsuarioExists(usuario.Id_usuario))
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
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
<<<<<<< HEAD
        public async Task<IActionResult> Delete(string id)
=======
        public async Task<IActionResult> Delete(int? id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
<<<<<<< HEAD
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
=======
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> DeleteConfirmed(string id)
=======
        public async Task<IActionResult> DeleteConfirmed(int id)
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'SinmpleContext.Usuario'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
            }
<<<<<<< HEAD

=======
            
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

<<<<<<< HEAD
        private bool UsuarioExists(string id)
        {
            return _context.Usuario.Any(e => e.IdUsuario == id);
=======
        private bool UsuarioExists(int id)
        {
          return (_context.Usuario?.Any(e => e.Id_usuario == id)).GetValueOrDefault();
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
        }
    }
}
