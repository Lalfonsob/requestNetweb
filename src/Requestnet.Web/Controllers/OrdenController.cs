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
    public class OrdenController : Controller
    {
        private readonly RequestnetDbContext _context;

        public OrdenController(RequestnetDbContext context)
        {
            _context = context;
        }

        // GET: Orden
        public async Task<IActionResult> Index()
        {
            var requestnetDbContext = _context.Orden.Include(o => o.IdEstadoNavigation).Include(o => o.IdJefeNavigation).Include(o => o.IdLiderNavigation).Include(o => o.IdProveedorNavigation).Include(o => o.IdTipoOrdenNavigation);
            return View(await requestnetDbContext.ToListAsync());
        }

        // GET: Orden/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Orden
                .Include(o => o.IdEstadoNavigation)
                .Include(o => o.IdJefeNavigation)
                .Include(o => o.IdLiderNavigation)
                .Include(o => o.IdProveedorNavigation)
                .Include(o => o.IdTipoOrdenNavigation)
                .FirstOrDefaultAsync(m => m.IdOrden == id);
            if (orden == null)
            {
                return NotFound();
            }

            return View(orden);
        }

        // GET: Orden/Create
        public IActionResult Create()
        {
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado");
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe");
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider");
            ViewData["IdProveedor"] = new SelectList(_context.Proveedores, "IdProveedor", "IdProveedor");
            ViewData["IdTipoOrden"] = new SelectList(_context.TipoOrden, "IdTipoOrden", "IdTipoOrden");
            return View();
        }

        // POST: Orden/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdOrden,Descripcion,AdjuntarArchivo,FechaAprobacion,Solucion,FechaSolucion,Notas,IdProveedor,IdLider,IdJefe,IdTipoOrden,IdEstado")] Orden orden)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orden);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", orden.IdEstado);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", orden.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", orden.IdLider);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedores, "IdProveedor", "IdProveedor", orden.IdProveedor);
            ViewData["IdTipoOrden"] = new SelectList(_context.TipoOrden, "IdTipoOrden", "IdTipoOrden", orden.IdTipoOrden);
            return View(orden);
        }

        // GET: Orden/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Orden.FindAsync(id);
            if (orden == null)
            {
                return NotFound();
            }
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", orden.IdEstado);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", orden.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", orden.IdLider);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedores, "IdProveedor", "IdProveedor", orden.IdProveedor);
            ViewData["IdTipoOrden"] = new SelectList(_context.TipoOrden, "IdTipoOrden", "IdTipoOrden", orden.IdTipoOrden);
            return View(orden);
        }

        // POST: Orden/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdOrden,Descripcion,AdjuntarArchivo,FechaAprobacion,Solucion,FechaSolucion,Notas,IdProveedor,IdLider,IdJefe,IdTipoOrden,IdEstado")] Orden orden)
        {
            if (id != orden.IdOrden)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orden);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenExists(orden.IdOrden))
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
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", orden.IdEstado);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", orden.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", orden.IdLider);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedores, "IdProveedor", "IdProveedor", orden.IdProveedor);
            ViewData["IdTipoOrden"] = new SelectList(_context.TipoOrden, "IdTipoOrden", "IdTipoOrden", orden.IdTipoOrden);
            return View(orden);
        }

        // GET: Orden/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Orden
                .Include(o => o.IdEstadoNavigation)
                .Include(o => o.IdJefeNavigation)
                .Include(o => o.IdLiderNavigation)
                .Include(o => o.IdProveedorNavigation)
                .Include(o => o.IdTipoOrdenNavigation)
                .FirstOrDefaultAsync(m => m.IdOrden == id);
            if (orden == null)
            {
                return NotFound();
            }

            return View(orden);
        }

        // POST: Orden/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orden = await _context.Orden.FindAsync(id);
            _context.Orden.Remove(orden);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdenExists(int id)
        {
            return _context.Orden.Any(e => e.IdOrden == id);
        }
    }
}
