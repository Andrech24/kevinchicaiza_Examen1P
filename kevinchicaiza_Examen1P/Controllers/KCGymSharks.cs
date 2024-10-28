using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kevinchicaiza_Examen1P.Data;
using kevinchicaiza_Examen1P.Models;

namespace kevinchicaiza_Examen1P.Controllers
{
    public class KCGymSharks : Controller
    {
        private readonly kevinchicaiza_Examen1PContext _context;

        public KCGymSharks(kevinchicaiza_Examen1PContext context)
        {
            _context = context;
        }

        // GET: KCGymSharks
        public async Task<IActionResult> Index()
        {
            return View(await _context.KcGymshark.ToListAsync());
        }

        // GET: KCGymSharks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kcGymshark = await _context.KcGymshark
                .FirstOrDefaultAsync(m => m.KCRopaid == id);
            if (kcGymshark == null)
            {
                return NotFound();
            }

            return View(kcGymshark);
        }

        // GET: KCGymSharks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KCGymSharks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KCRopaid,KCName,KCtallas,KCPrecio,Emaildelusuario,KCFechadeEntrada,KCFechadeSalida,KCColor,KCGenero,KcTipodegenero,KCDescripcion")] KcGymshark kcGymshark)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kcGymshark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kcGymshark);
        }

        // GET: KCGymSharks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kcGymshark = await _context.KcGymshark.FindAsync(id);
            if (kcGymshark == null)
            {
                return NotFound();
            }
            return View(kcGymshark);
        }

        // POST: KCGymSharks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KCRopaid,KCName,KCtallas,KCPrecio,Emaildelusuario,KCFechadeEntrada,KCFechadeSalida,KCColor,KCGenero,KcTipodegenero,KCDescripcion")] KcGymshark kcGymshark)
        {
            if (id != kcGymshark.KCRopaid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kcGymshark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KcGymsharkExists(kcGymshark.KCRopaid))
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
            return View(kcGymshark);
        }

        // GET: KCGymSharks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kcGymshark = await _context.KcGymshark
                .FirstOrDefaultAsync(m => m.KCRopaid == id);
            if (kcGymshark == null)
            {
                return NotFound();
            }

            return View(kcGymshark);
        }

        // POST: KCGymSharks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kcGymshark = await _context.KcGymshark.FindAsync(id);
            if (kcGymshark != null)
            {
                _context.KcGymshark.Remove(kcGymshark);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KcGymsharkExists(int id)
        {
            return _context.KcGymshark.Any(e => e.KCRopaid == id);
        }
    }
}
