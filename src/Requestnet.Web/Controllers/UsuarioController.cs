using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Requestnet.Core.Domain;
using Requestnet.Infrastructure.Data;

namespace Requestnet.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly RequestnetDbContext _context;

        public UsuarioController(RequestnetDbContext context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            var requestnetDbContext = _context.Usuarios.Include(u => u.IdCiudadNavigation).Include(u => u.IdEstadoruNavigation).Include(u => u.IdRolNavigation).Include(u => u.IdTipdocNavigation);
            return View(await requestnetDbContext.ToListAsync());
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios
                .Include(u => u.IdCiudadNavigation)
                .Include(u => u.IdEstadoruNavigation)
                .Include(u => u.IdRolNavigation)
                .Include(u => u.IdTipdocNavigation)
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuarios == null)
            {
                return NotFound();
            }

            return View(usuarios);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            ViewData["IdCiudad"] = new SelectList(_context.Ciudades, "IdCiudad", "IdCiudad");
            ViewData["IdEstadoru"] = new SelectList(_context.EstadosRu, "IdEstadoru", "IdEstadoru");
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol");
            ViewData["IdTipdoc"] = new SelectList(_context.TipoDoc, "IdTipdoc", "IdTipdoc");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,IdTipdoc,NumDocumento,Nombres,Apellidos,Telefono,Correo,IdCiudad,Direccion,FechaNacimiento,FechaIngresoCom,Cargo,IdRol,Contraseña,IdEstadoru")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCiudad"] = new SelectList(_context.Ciudades, "IdCiudad", "IdCiudad", usuarios.IdCiudad);
            ViewData["IdEstadoru"] = new SelectList(_context.EstadosRu, "IdEstadoru", "IdEstadoru", usuarios.IdEstadoru);
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol", usuarios.IdRol);
            ViewData["IdTipdoc"] = new SelectList(_context.TipoDoc, "IdTipdoc", "IdTipdoc", usuarios.IdTipdoc);
            return View(usuarios);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            ViewData["IdCiudad"] = new SelectList(_context.Ciudades, "IdCiudad", "IdCiudad", usuarios.IdCiudad);
            ViewData["IdEstadoru"] = new SelectList(_context.EstadosRu, "IdEstadoru", "IdEstadoru", usuarios.IdEstadoru);
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol", usuarios.IdRol);
            ViewData["IdTipdoc"] = new SelectList(_context.TipoDoc, "IdTipdoc", "IdTipdoc", usuarios.IdTipdoc);
            return View(usuarios);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,IdTipdoc,NumDocumento,Nombres,Apellidos,Telefono,Correo,IdCiudad,Direccion,FechaNacimiento,FechaIngresoCom,Cargo,IdRol,Contraseña,IdEstadoru")] Usuarios usuarios)
        {
            if (id != usuarios.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuariosExists(usuarios.IdUsuario))
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
            ViewData["IdCiudad"] = new SelectList(_context.Ciudades, "IdCiudad", "IdCiudad", usuarios.IdCiudad);
            ViewData["IdEstadoru"] = new SelectList(_context.EstadosRu, "IdEstadoru", "IdEstadoru", usuarios.IdEstadoru);
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol", usuarios.IdRol);
            ViewData["IdTipdoc"] = new SelectList(_context.TipoDoc, "IdTipdoc", "IdTipdoc", usuarios.IdTipdoc);
            return View(usuarios);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios
                .Include(u => u.IdCiudadNavigation)
                .Include(u => u.IdEstadoruNavigation)
                .Include(u => u.IdRolNavigation)
                .Include(u => u.IdTipdocNavigation)
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuarios == null)
            {
                return NotFound();
            }

            return View(usuarios);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuariosExists(int id)
        {
            return _context.Usuarios.Any(e => e.IdUsuario == id);
        }
    }
}
