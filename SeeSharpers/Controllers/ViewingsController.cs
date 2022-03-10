#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeeSharpers.Data;
using SeeSharpers.Models;

namespace SeeSharpers.Controllers
{
    public class ViewingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Viewings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Viewings.ToListAsync());
        }

        // GET: Viewings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewing = await _context.Viewings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viewing == null)
            {
                return NotFound();
            }

            return View(viewing);
        }

        // GET: Viewings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Viewings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDateTime")] Viewing viewing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viewing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewing);
        }

        // GET: Viewings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewing = await _context.Viewings.FindAsync(id);
            if (viewing == null)
            {
                return NotFound();
            }
            return View(viewing);
        }

        // POST: Viewings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDateTime")] Viewing viewing)
        {
            if (id != viewing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viewing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViewingExists(viewing.Id))
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
            return View(viewing);
        }

        // GET: Viewings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewing = await _context.Viewings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viewing == null)
            {
                return NotFound();
            }

            return View(viewing);
        }

        // POST: Viewings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viewing = await _context.Viewings.FindAsync(id);
            _context.Viewings.Remove(viewing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViewingExists(int id)
        {
            return _context.Viewings.Any(e => e.Id == id);
        }
    }
}
