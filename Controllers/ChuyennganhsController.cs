using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using qlthpt.Models;

namespace qlthpt.Controllers
{
    public class ChuyennganhsController : Controller
    {
        private acomptec_qlthptContext _context;

        public ChuyennganhsController(acomptec_qlthptContext context)
        {
            _context = context;
        }

        // GET: Chuyennganhs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chuyennganh.ToListAsync());
        }

        // GET: Chuyennganhs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuyennganh = await _context.Chuyennganh
                .FirstOrDefaultAsync(m => m.CnMa == id);
            if (chuyennganh == null)
            {
                return NotFound();
            }

            return View(chuyennganh);
        }

        // GET: Chuyennganhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chuyennganhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CnMa,CnTen")] Chuyennganh chuyennganh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuyennganh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuyennganh);
        }

        // GET: Chuyennganhs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuyennganh = await _context.Chuyennganh.FindAsync(id);
            if (chuyennganh == null)
            {
                return NotFound();
            }
            return View(chuyennganh);
        }

        // POST: Chuyennganhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CnMa,CnTen")] Chuyennganh chuyennganh)
        {
            if (id != chuyennganh.CnMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuyennganh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuyennganhExists(chuyennganh.CnMa))
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
            return View(chuyennganh);
        }

        // GET: Chuyennganhs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuyennganh = await _context.Chuyennganh
                .FirstOrDefaultAsync(m => m.CnMa == id);
            if (chuyennganh == null)
            {
                return NotFound();
            }

            return View(chuyennganh);
        }

        // POST: Chuyennganhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chuyennganh = await _context.Chuyennganh.FindAsync(id);
            _context.Chuyennganh.Remove(chuyennganh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChuyennganhExists(string id)
        {
            return _context.Chuyennganh.Any(e => e.CnMa == id);
        }
    }
}