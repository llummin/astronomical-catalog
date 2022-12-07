﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Space.Models;

namespace Space.Controllers
{
    public class BlackHolesController : Controller
    {
        private readonly SpaceContext _context;

        public BlackHolesController(SpaceContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var spaceContext = _context.BlackHoles.Include(b => b.Cons).Include(b => b.Glx);
            return View(await spaceContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BlackHoles == null)
            {
                return NotFound();
            }

            var blackHoles = await _context.BlackHoles
                .Include(b => b.Cons)
                .Include(b => b.Glx)
                .FirstOrDefaultAsync(m => m.BlackHoleId == id);
            if (blackHoles == null)
            {
                return NotFound();
            }

            return View(blackHoles);
        }

        public IActionResult Create()
        {
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName");
            ViewData["GlxId"] = new SelectList(_context.Galaxies, "GlxId", "GlxName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlackHoleId,ConsId,GlxId,BlackholeName,BlackholeType,BlackholeRightAscension,BlackholeDeclination,BlackholeDistance")] BlackHoles blackHoles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blackHoles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName", blackHoles.ConsId);
            ViewData["GlxId"] = new SelectList(_context.Galaxies, "GlxId", "GlxName", blackHoles.GlxId);
            return View(blackHoles);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BlackHoles == null)
            {
                return NotFound();
            }

            var blackHoles = await _context.BlackHoles.FindAsync(id);
            if (blackHoles == null)
            {
                return NotFound();
            }
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName", blackHoles.ConsId);
            ViewData["GlxId"] = new SelectList(_context.Galaxies, "GlxId", "GlxName", blackHoles.GlxId);
            return View(blackHoles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlackHoleId,ConsId,GlxId,BlackholeName,BlackholeType,BlackholeRightAscension,BlackholeDeclination,BlackholeDistance")] BlackHoles blackHoles)
        {
            if (id != blackHoles.BlackHoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blackHoles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlackHolesExists(blackHoles.BlackHoleId))
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
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName", blackHoles.ConsId);
            ViewData["GlxId"] = new SelectList(_context.Galaxies, "GlxId", "GlxName", blackHoles.GlxId);
            return View(blackHoles);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BlackHoles == null)
            {
                return NotFound();
            }

            var blackHoles = await _context.BlackHoles
                .Include(b => b.Cons)
                .Include(b => b.Glx)
                .FirstOrDefaultAsync(m => m.BlackHoleId == id);
            if (blackHoles == null)
            {
                return NotFound();
            }

            return View(blackHoles);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BlackHoles == null)
            {
                return Problem("Entity set 'SpaceContext.BlackHoles'  is null.");
            }
            var blackHoles = await _context.BlackHoles.FindAsync(id);
            if (blackHoles != null)
            {
                _context.BlackHoles.Remove(blackHoles);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlackHolesExists(int id)
        {
          return (_context.BlackHoles?.Any(e => e.BlackHoleId == id)).GetValueOrDefault();
        }
    }
}