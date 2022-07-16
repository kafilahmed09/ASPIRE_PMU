using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPIRE.Data;
using ASPIRE.Models.Domain.MasterSetup;

namespace ASPIRE.Controllers.MasterSetup
{
    public class TehsilsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TehsilsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.Id = id;
            var applicationDbContext = _context.Tehsil.Include(t => t.District.Division.Provience).Where(a=>a.DistrictId == id);
            ViewBag.DivisionName = applicationDbContext.Select(a => a.District.Division.Name).FirstOrDefault();
            ViewBag.DistrictName = applicationDbContext.Select(a => a.District.Name).FirstOrDefault();
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Tehsils
        public async Task<IActionResult> DistrictIndex(int id)
        {
            var applicationDbContext = _context.District.Include(a=>a.Division.Provience).Where(a=>a.DivisionId == id);
            ViewBag.DivisionName = applicationDbContext.Select(a => a.Division.Name).FirstOrDefault();
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> DivisionIndex()
        {
            var applicationDbContext = _context.Division.Include(a=>a.Provience);            
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Tehsils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tehsil = await _context.Tehsil
                .Include(t => t.District)
                .FirstOrDefaultAsync(m => m.TehsilId == id);
            if (tehsil == null)
            {
                return NotFound();
            }

            return View(tehsil);
        }

        // GET: Tehsils/Create
        public IActionResult Create(int val, int id)
        {
            ViewBag.Id = id;
            if (val == 1)
            {
                ViewBag.message = "Tehsil Already Exist!";
            }
            else if(val == 2)
            {
                ViewBag.message = "Tehsil Added Successfully!";
            }            
            ViewBag.val = val;
            ViewData["DistrictId"] = new SelectList(_context.District.Where(a=>a.DistrictId == id), "DistrictId", "Name");
            return View();
        }

        // POST: Tehsils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TehsilId,TehsilName,DistrictId")] Tehsil tehsil)
        {
            if (ModelState.IsValid)
            {                
                var result = _context.Tehsil.Count(a => a.TehsilName.ToLower() == tehsil.TehsilName.ToLower());
                if (result == 0)
                {
                    _context.Add(tehsil);
                    await _context.SaveChangesAsync();
                }
                else
                {                    
                    return RedirectToAction(nameof(Create), new {val = 1, id = tehsil.DistrictId });
                }                
                return RedirectToAction(nameof(Create), new { val = 2, id = tehsil.DistrictId });
            }
            ViewData["DistrictId"] = new SelectList(_context.District, "DistrictId", "Name", tehsil.DistrictId);
            return View(tehsil);
        }

        // GET: Tehsils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tehsil = await _context.Tehsil.FindAsync(id);
            if (tehsil == null)
            {
                return NotFound();
            }
            ViewData["DistrictId"] = new SelectList(_context.District, "DistrictId", "Name", tehsil.DistrictId);
            return View(tehsil);
        }

        // POST: Tehsils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TehsilId,TehsilName,DistrictId")] Tehsil tehsil)
        {
            if (id != tehsil.TehsilId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tehsil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TehsilExists(tehsil.TehsilId))
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
            ViewData["DistrictId"] = new SelectList(_context.District, "DistrictId", "Name", tehsil.DistrictId);
            return View(tehsil);
        }

        // GET: Tehsils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tehsil = await _context.Tehsil
                .Include(t => t.District)
                .FirstOrDefaultAsync(m => m.TehsilId == id);
            if (tehsil == null)
            {
                return NotFound();
            }

            return View(tehsil);
        }

        // POST: Tehsils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tehsil = await _context.Tehsil.FindAsync(id);
            _context.Tehsil.Remove(tehsil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TehsilExists(int id)
        {
            return _context.Tehsil.Any(e => e.TehsilId == id);
        }
    }
}
