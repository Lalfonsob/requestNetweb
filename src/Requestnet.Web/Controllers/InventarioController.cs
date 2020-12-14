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
    public class InventarioController : Controller
    {
        private readonly RequestnetDbContext _context;

        public InventarioController(RequestnetDbContext context)
        {
            _context = context;
        }

        // GET: Inventario
        public async Task<IActionResult> Index()
        {
            var requestnetDbContext = _context.InventarioEquipos.Include(i => i.IdClienteNavigation).Include(i => i.IdEstadoeqNavigation).Include(i => i.IdJefeNavigation).Include(i => i.IdLiderNavigation).Include(i => i.IdMarcaNavigation).Include(i => i.IdTipoComponenteNavigation).Include(i => i.IdTipoProcedenciaNavigation);
            return View(await requestnetDbContext.ToListAsync());
        }

        // GET: Inventario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioEquipos = await _context.InventarioEquipos
                .Include(i => i.IdClienteNavigation)
                .Include(i => i.IdEstadoeqNavigation)
                .Include(i => i.IdJefeNavigation)
                .Include(i => i.IdLiderNavigation)
                .Include(i => i.IdMarcaNavigation)
                .Include(i => i.IdTipoComponenteNavigation)
                .Include(i => i.IdTipoProcedenciaNavigation)
                .FirstOrDefaultAsync(m => m.IdEquipo == id);
            if (inventarioEquipos == null)
            {
                return NotFound();
            }

            return View(inventarioEquipos);
        }

        // GET: Inventario/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente");
            ViewData["IdEstadoeq"] = new SelectList(_context.EstadoEq, "IdEstadoeq", "IdEstadoeq");
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe");
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider");
            ViewData["IdMarca"] = new SelectList(_context.Marca, "IdMarca", "IdMarca");
            ViewData["IdTipoComponente"] = new SelectList(_context.TipoComponente, "IdTipoComponente", "IdTipoComponente");
            ViewData["IdTipoProcedencia"] = new SelectList(_context.TipoProcedencia, "IdTipoProcedencia", "IdTipoProcedencia");
            return View();
        }

        // POST: Inventario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEquipo,IdEstadoeq,Serial,IdCliente,IdTipoComponente,IdMarca,IdTipoProcedencia,IdJefe,IdLider")] InventarioEquipos inventarioEquipos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventarioEquipos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente", inventarioEquipos.IdCliente);
            ViewData["IdEstadoeq"] = new SelectList(_context.EstadoEq, "IdEstadoeq", "IdEstadoeq", inventarioEquipos.IdEstadoeq);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", inventarioEquipos.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", inventarioEquipos.IdLider);
            ViewData["IdMarca"] = new SelectList(_context.Marca, "IdMarca", "IdMarca", inventarioEquipos.IdMarca);
            ViewData["IdTipoComponente"] = new SelectList(_context.TipoComponente, "IdTipoComponente", "IdTipoComponente", inventarioEquipos.IdTipoComponente);
            ViewData["IdTipoProcedencia"] = new SelectList(_context.TipoProcedencia, "IdTipoProcedencia", "IdTipoProcedencia", inventarioEquipos.IdTipoProcedencia);
            return View(inventarioEquipos);
        }

        // GET: Inventario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioEquipos = await _context.InventarioEquipos.FindAsync(id);
            if (inventarioEquipos == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente", inventarioEquipos.IdCliente);
            ViewData["IdEstadoeq"] = new SelectList(_context.EstadoEq, "IdEstadoeq", "IdEstadoeq", inventarioEquipos.IdEstadoeq);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", inventarioEquipos.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", inventarioEquipos.IdLider);
            ViewData["IdMarca"] = new SelectList(_context.Marca, "IdMarca", "IdMarca", inventarioEquipos.IdMarca);
            ViewData["IdTipoComponente"] = new SelectList(_context.TipoComponente, "IdTipoComponente", "IdTipoComponente", inventarioEquipos.IdTipoComponente);
            ViewData["IdTipoProcedencia"] = new SelectList(_context.TipoProcedencia, "IdTipoProcedencia", "IdTipoProcedencia", inventarioEquipos.IdTipoProcedencia);
            return View(inventarioEquipos);
        }

        // POST: Inventario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEquipo,IdEstadoeq,Serial,IdCliente,IdTipoComponente,IdMarca,IdTipoProcedencia,IdJefe,IdLider")] InventarioEquipos inventarioEquipos)
        {
            if (id != inventarioEquipos.IdEquipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventarioEquipos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioEquiposExists(inventarioEquipos.IdEquipo))
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
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente", inventarioEquipos.IdCliente);
            ViewData["IdEstadoeq"] = new SelectList(_context.EstadoEq, "IdEstadoeq", "IdEstadoeq", inventarioEquipos.IdEstadoeq);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", inventarioEquipos.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", inventarioEquipos.IdLider);
            ViewData["IdMarca"] = new SelectList(_context.Marca, "IdMarca", "IdMarca", inventarioEquipos.IdMarca);
            ViewData["IdTipoComponente"] = new SelectList(_context.TipoComponente, "IdTipoComponente", "IdTipoComponente", inventarioEquipos.IdTipoComponente);
            ViewData["IdTipoProcedencia"] = new SelectList(_context.TipoProcedencia, "IdTipoProcedencia", "IdTipoProcedencia", inventarioEquipos.IdTipoProcedencia);
            return View(inventarioEquipos);
        }

        // GET: Inventario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioEquipos = await _context.InventarioEquipos
                .Include(i => i.IdClienteNavigation)
                .Include(i => i.IdEstadoeqNavigation)
                .Include(i => i.IdJefeNavigation)
                .Include(i => i.IdLiderNavigation)
                .Include(i => i.IdMarcaNavigation)
                .Include(i => i.IdTipoComponenteNavigation)
                .Include(i => i.IdTipoProcedenciaNavigation)
                .FirstOrDefaultAsync(m => m.IdEquipo == id);
            if (inventarioEquipos == null)
            {
                return NotFound();
            }

            return View(inventarioEquipos);
        }

        // POST: Inventario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventarioEquipos = await _context.InventarioEquipos.FindAsync(id);
            _context.InventarioEquipos.Remove(inventarioEquipos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioEquiposExists(int id)
        {
            return _context.InventarioEquipos.Any(e => e.IdEquipo == id);
        }
    }
}
