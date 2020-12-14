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
    public class CasoController : Controller
    {
        private readonly RequestnetDbContext _context;

        public CasoController(RequestnetDbContext context)
        {
            _context = context;
        }

        // GET: Caso
        public async Task<IActionResult> Index()
        {
            var requestnetDbContext = _context.Casos.Include(c => c.IdClienteNavigation).Include(c => c.IdEstadoNavigation).Include(c => c.IdJefeNavigation).Include(c => c.IdLiderNavigation).Include(c => c.IdTecnicoNavigation).Include(c => c.IdTipoCasoNavigation);
            return View(await requestnetDbContext.ToListAsync());
        }

        // GET: Caso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casos = await _context.Casos
                .Include(c => c.IdClienteNavigation)
                .Include(c => c.IdEstadoNavigation)
                .Include(c => c.IdJefeNavigation)
                .Include(c => c.IdLiderNavigation)
                .Include(c => c.IdTecnicoNavigation)
                .Include(c => c.IdTipoCasoNavigation)
                .FirstOrDefaultAsync(m => m.IdCaso == id);
            if (casos == null)
            {
                return NotFound();
            }

            return View(casos);
        }

        // GET: Caso/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente");
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado");
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe");
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider");
            ViewData["IdTecnico"] = new SelectList(_context.Tecnico, "IdTecnico", "IdTecnico");
            ViewData["IdTipoCaso"] = new SelectList(_context.TipoCaso, "IdTipoCaso", "IdTipoCaso");
            return View();
        }

        // POST: Caso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCaso,FechaCreacion,Descripcion,Solucion,FechaSol,Notas,IdTipoCaso,IdTecnico,IdJefe,IdLider,IdEstado,IdCliente")] Casos casos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente", casos.IdCliente);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", casos.IdEstado);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", casos.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", casos.IdLider);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnico, "IdTecnico", "IdTecnico", casos.IdTecnico);
            ViewData["IdTipoCaso"] = new SelectList(_context.TipoCaso, "IdTipoCaso", "IdTipoCaso", casos.IdTipoCaso);
            return View(casos);
        }

        // GET: Caso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casos = await _context.Casos.FindAsync(id);
            if (casos == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente", casos.IdCliente);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", casos.IdEstado);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", casos.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", casos.IdLider);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnico, "IdTecnico", "IdTecnico", casos.IdTecnico);
            ViewData["IdTipoCaso"] = new SelectList(_context.TipoCaso, "IdTipoCaso", "IdTipoCaso", casos.IdTipoCaso);
            return View(casos);
        }

        // POST: Caso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCaso,FechaCreacion,Descripcion,Solucion,FechaSol,Notas,IdTipoCaso,IdTecnico,IdJefe,IdLider,IdEstado,IdCliente")] Casos casos)
        {
            if (id != casos.IdCaso)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasosExists(casos.IdCaso))
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
            ViewData["IdCliente"] = new SelectList(_context.IntegranteColaborador, "IdCliente", "IdCliente", casos.IdCliente);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", casos.IdEstado);
            ViewData["IdJefe"] = new SelectList(_context.Jefeinfraestructura, "IdJefe", "IdJefe", casos.IdJefe);
            ViewData["IdLider"] = new SelectList(_context.Liderinventario, "IdLider", "IdLider", casos.IdLider);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnico, "IdTecnico", "IdTecnico", casos.IdTecnico);
            ViewData["IdTipoCaso"] = new SelectList(_context.TipoCaso, "IdTipoCaso", "IdTipoCaso", casos.IdTipoCaso);
            return View(casos);
        }

        // GET: Caso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casos = await _context.Casos
                .Include(c => c.IdClienteNavigation)
                .Include(c => c.IdEstadoNavigation)
                .Include(c => c.IdJefeNavigation)
                .Include(c => c.IdLiderNavigation)
                .Include(c => c.IdTecnicoNavigation)
                .Include(c => c.IdTipoCasoNavigation)
                .FirstOrDefaultAsync(m => m.IdCaso == id);
            if (casos == null)
            {
                return NotFound();
            }

            return View(casos);
        }

        // POST: Caso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casos = await _context.Casos.FindAsync(id);
            _context.Casos.Remove(casos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CasosExists(int id)
        {
            return _context.Casos.Any(e => e.IdCaso == id);
        }
    }
}
