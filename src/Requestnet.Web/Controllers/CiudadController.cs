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
    public class CiudadController : Controller
    {
        private readonly RequestnetDbContext _context;

        public CiudadController(RequestnetDbContext context)
        {
            _context = context;
        }

        // GET: Ciudad
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ciudades.ToListAsync());
        }

        // GET: Ciudad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudades = await _context.Ciudades
                .FirstOrDefaultAsync(m => m.IdCiudad == id);
            if (ciudades == null)
            {
                return NotFound();
            }

            return View(ciudades);
        }

        // GET: Ciudad/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ciudad/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCiudad")] Ciudades ciudades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciudades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ciudades);
        }

        // GET: Ciudad/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudades = await _context.Ciudades.FindAsync(id);
            if (ciudades == null)
            {
                return NotFound();
            }
            return View(ciudades);
        }

        // POST: Ciudad/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCiudad")] Ciudades ciudades)
        {
            if (id != ciudades.IdCiudad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciudades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CiudadesExists(ciudades.IdCiudad))
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
            return View(ciudades);
        }

        // GET: Ciudad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudades = await _context.Ciudades
                .FirstOrDefaultAsync(m => m.IdCiudad == id);
            if (ciudades == null)
            {
                return NotFound();
            }

            return View(ciudades);
        }

        // POST: Ciudad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ciudades = await _context.Ciudades.FindAsync(id);
            _context.Ciudades.Remove(ciudades);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CiudadesExists(int id)
        {
            return _context.Ciudades.Any(e => e.IdCiudad == id);
        }
    }
}
