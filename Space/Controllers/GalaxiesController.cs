﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Space.Models;

namespace Space.Controllers
{
    public class GalaxiesController : Controller
    {
        private readonly SpaceContext _context;

        public GalaxiesController(SpaceContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var spaceContext = _context.Galaxies.Include(g => g.Cons).Include(g => g.Glxcluster).Include(g => g.Glxgroup);
            return View(await spaceContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Galaxies == null)
            {
                return NotFound();
            }

            var galaxies = await _context.Galaxies
                .Include(g => g.Cons)
                .Include(g => g.Glxcluster)
                .Include(g => g.Glxgroup)
                .FirstOrDefaultAsync(m => m.GlxId == id);
            if (galaxies == null)
            {
                return NotFound();
            }

            return View(galaxies);
        }

        public IActionResult Create()
        {
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName");
            ViewData["GlxclusterId"] = new SelectList(_context.GalaxyClusters, "GlxclusterId", "GlxclusterName");
            ViewData["GlxgroupId"] = new SelectList(_context.GalaxyGroups, "GlxgroupId", "GlxgroupName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GlxId,ConsId,GlxclusterId,GlxgroupId,GlxName,GlxType,GlxRightAscension,GlxDeclination,GlxRedshift,GlxDistance,GlxApparentMagnitude,GlxRadialVelocity,GlxRadius")] Galaxies galaxies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(galaxies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName", galaxies.ConsId);
            ViewData["GlxclusterId"] = new SelectList(_context.GalaxyClusters, "GlxclusterId", "GlxclusterName", galaxies.GlxclusterId);
            ViewData["GlxgroupId"] = new SelectList(_context.GalaxyGroups, "GlxgroupId", "GlxgroupName", galaxies.GlxgroupId);
            return View(galaxies);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Galaxies == null)
            {
                return NotFound();
            }

            var galaxies = await _context.Galaxies.FindAsync(id);
            if (galaxies == null)
            {
                return NotFound();
            }
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName", galaxies.ConsId);
            ViewData["GlxclusterId"] = new SelectList(_context.GalaxyClusters, "GlxclusterId", "GlxclusterName", galaxies.GlxclusterId);
            ViewData["GlxgroupId"] = new SelectList(_context.GalaxyGroups, "GlxgroupId", "GlxgroupName", galaxies.GlxgroupId);
            return View(galaxies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GlxId,ConsId,GlxclusterId,GlxgroupId,GlxName,GlxType,GlxRightAscension,GlxDeclination,GlxRedshift,GlxDistance,GlxApparentMagnitude,GlxRadialVelocity,GlxRadius")] Galaxies galaxies)
        {
            if (id != galaxies.GlxId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(galaxies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GalaxiesExists(galaxies.GlxId))
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
            ViewData["ConsId"] = new SelectList(_context.Constellations, "ConsId", "ConsName", galaxies.ConsId);
            ViewData["GlxclusterId"] = new SelectList(_context.GalaxyClusters, "GlxclusterId", "GlxclusterName", galaxies.GlxclusterId);
            ViewData["GlxgroupId"] = new SelectList(_context.GalaxyGroups, "GlxgroupId", "GlxgroupName", galaxies.GlxgroupId);
            return View(galaxies);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Galaxies == null)
            {
                return NotFound();
            }

            var galaxies = await _context.Galaxies
                .Include(g => g.Cons)
                .Include(g => g.Glxcluster)
                .Include(g => g.Glxgroup)
                .FirstOrDefaultAsync(m => m.GlxId == id);
            if (galaxies == null)
            {
                return NotFound();
            }

            return View(galaxies);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Galaxies == null)
            {
                return Problem("Entity set 'SpaceContext.Galaxies'  is null.");
            }
            var galaxies = await _context.Galaxies
                .Include(g => g.Stars)
                .Include(g => g.BlackHoles)
                .Include(g => g.Nebulae)
                .Include(g => g.PlanetarySystems)
                .Include(g => g.StarClusters)
                .FirstOrDefaultAsync(m => m.GlxId == id);
            if (galaxies != null)
            {
                _context.Galaxies.Remove(galaxies);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GalaxiesExists(int id)
        {
          return (_context.Galaxies?.Any(e => e.GlxId == id)).GetValueOrDefault();
        }
    }
}
