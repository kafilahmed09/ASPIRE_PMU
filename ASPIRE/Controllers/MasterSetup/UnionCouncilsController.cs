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
    public class UnionCouncilsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UnionCouncilsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UnionCouncils
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.Id = id;
            var applicationDbContext = _context.UnionCouncil.Include(u => u.Tehsil.District).Where(a=>a.TehsilId == id);
            ViewBag.DivisionName = applicationDbContext.Select(a => a.Tehsil.District.Division.Name).FirstOrDefault();
            ViewBag.DistrictName = applicationDbContext.Select(a => a.Tehsil.District.Name).FirstOrDefault();
            ViewBag.TehsilName = applicationDbContext.Select(a => a.Tehsil.TehsilName).FirstOrDefault();
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> DivisionIndex()
        {
            var applicationDbContext = _context.Division.Include(a => a.Provience);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> DistrictIndex(int id)
        {
            var applicationDbContext = _context.District.Include(a => a.Division).Where(a=>a.DivisionId == id);
            ViewBag.DivisionName = applicationDbContext.Select(a => a.Division.Name).FirstOrDefault();
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> TehsilIndex(int id)
        {
            var applicationDbContext = _context.Tehsil.Include(u => u.District.Division)
                                                .Where(a=>a.DistrictId == id);
            ViewBag.DivisionName = applicationDbContext.Select(a => a.District.Division.Name).FirstOrDefault();
            ViewBag.DistrictName = applicationDbContext.Select(a => a.District.Name).FirstOrDefault();
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: UnionCouncils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionCouncil = await _context.UnionCouncil
                .Include(u => u.Tehsil)
                .FirstOrDefaultAsync(m => m.UnionCouncilId == id);
            if (unionCouncil == null)
            {
                return NotFound();
            }

            return View(unionCouncil);
        }

        // GET: UnionCouncils/Create
        public IActionResult Create(int val, int id)
        {
            ViewBag.Id = id;
            if (val == 1)
            {
                ViewBag.message = "Union Council Already Exist!";
            }
            else if(val == 2)
            {
                ViewBag.message = "Union Council Added Successfully!";
            }            
            ViewBag.val = val;
            ViewData["TehsilId"] = new SelectList(_context.Tehsil.Where(a=>a.TehsilId == id), "TehsilId", "TehsilName");
            return View();
        }

        // POST: UnionCouncils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnionCouncilId,UnionCouncilName,TehsilId")] UnionCouncil unionCouncil)
        {
            if (ModelState.IsValid)
            {                
                var result = _context.UnionCouncil.Count(a => a.UnionCouncilName.ToLower() == unionCouncil.UnionCouncilName.ToLower() && a.TehsilId == unionCouncil.UnionCouncilId);
                if (result == 0)
                {
                    _context.Add(unionCouncil);
                    await _context.SaveChangesAsync();
                }
                else
                {                    
                    return RedirectToAction(nameof(Create), new { val = 1, id = unionCouncil.TehsilId});
                }                
                return RedirectToAction(nameof(Create), new { val = 2, id = unionCouncil.TehsilId });
            }
            ViewData["TehsilId"] = new SelectList(_context.Tehsil, "TehsilId", "TehsilName", unionCouncil.TehsilId);
            return View(unionCouncil);
        }

        // GET: UnionCouncils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionCouncil = await _context.UnionCouncil.FindAsync(id);
            if (unionCouncil == null)
            {
                return NotFound();
            }
            ViewData["TehsilId"] = new SelectList(_context.Tehsil, "TehsilId", "TehsilName", unionCouncil.TehsilId);
            return View(unionCouncil);
        }

        // POST: UnionCouncils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UnionCouncilId,UnionCouncilName,TehsilId")] UnionCouncil unionCouncil)
        {
            if (id != unionCouncil.UnionCouncilId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unionCouncil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnionCouncilExists(unionCouncil.UnionCouncilId))
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
            ViewData["TehsilId"] = new SelectList(_context.Tehsil, "TehsilId", "TehsilName", unionCouncil.TehsilId);
            return View(unionCouncil);
        }

        // GET: UnionCouncils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionCouncil = await _context.UnionCouncil
                .Include(u => u.Tehsil)
                .FirstOrDefaultAsync(m => m.UnionCouncilId == id);
            if (unionCouncil == null)
            {
                return NotFound();
            }

            return View(unionCouncil);
        }

        // POST: UnionCouncils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unionCouncil = await _context.UnionCouncil.FindAsync(id);
            _context.UnionCouncil.Remove(unionCouncil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnionCouncilExists(int id)
        {
            return _context.UnionCouncil.Any(e => e.UnionCouncilId == id);
        }
    }
}
