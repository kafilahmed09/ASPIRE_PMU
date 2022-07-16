using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPIRE.Data;
using ASPIRE.Models.Domain.MasterSetup;

namespace ASPIRE.Controllers.MasterSetup
{
    [AllowAnonymous]
    public class DistrictsController : Controller
    {
        private readonly ApplicationDbContext _context;        

        public DistrictsController(ApplicationDbContext context)
        {
            _context = context;            
        }

        // GET: Districts
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.Id = id;
            var applicationDbContext = _context.District.Include(d => d.Division)
                                                .Where(a=>a.DivisionId == id);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> DivisionIndex()
        {
            var applicationDbContext = _context.Division;
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Districts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = await _context.District
                .Include(d => d.Division)
                .FirstOrDefaultAsync(m => m.DistrictId == id);
            if (district == null)
            {
                return NotFound();
            }

            return View(district);
        }

        // GET: Districts/Create
        public IActionResult Create(int val, int id)
        {
            ViewBag.Id = id;
            if (val == 1)
            {
                ViewBag.message = "District Already Exist!";
            }
            else if(val == 2)
            {
                ViewBag.message = "District Added Successfully!";
            }
            ViewBag.val = val;
            ViewBag.val = val;
            ViewData["DivisionId"] = new SelectList(_context.Division.Where(a=>a.DivisionId == id), "DivisionId", "Name");
            return View();
        }

        // POST: Districts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DistrictId,Name,Code,Description,DivisionId")] District district)
        {
            if (ModelState.IsValid)
            {                
                var result = _context.District.Count(a => a.Name.ToLower() == district.Name.ToLower());
                if (result == 0)
                {
                    _context.Add(district);
                    await _context.SaveChangesAsync();
                }
                else
                {                    
                    return RedirectToAction(nameof(Create), new { val = 1, id = district.DivisionId });
                }                
                return RedirectToAction(nameof(Create), new { val = 2, id = district.DivisionId });
            }
            ViewData["DivisionId"] = new SelectList(_context.Division, "DivisionId", "Name", district.DivisionId);
            return View(district);
        }

        // GET: Districts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = await _context.District.FindAsync(id);
            if (district == null)
            {
                return NotFound();
            }
            ViewData["DivisionId"] = new SelectList(_context.Division, "DivisionId", "Name", district.DivisionId);
            return View(district);
        }

        // POST: Districts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DistrictId,Name,Code,Description,DivisionId")] District district)
        {
            if (id != district.DistrictId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Entry(district).CurrentValues.SetValues(district);
                    _context.Update(district);
                    await _context.SaveChangesAsync(User?.FindFirst(ClaimTypes.NameIdentifier).Value);
                    /*_context.Update(district);
                    await _context.SaveChangesAsync();*/
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistrictExists(district.DistrictId))
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
            ViewData["DivisionId"] = new SelectList(_context.Division, "DivisionId", "Name", district.DivisionId);
            return View(district);
        }

        // GET: Districts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = await _context.District
                .Include(d => d.Division)
                .FirstOrDefaultAsync(m => m.DistrictId == id);
            if (district == null)
            {
                return NotFound();
            }

            return View(district);
        }

        // POST: Districts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var district = await _context.District.FindAsync(id);
            _context.District.Remove(district);
            //await _context.SaveChangesAsync();
            await _context.SaveChangesAsync(User?.FindFirst(ClaimTypes.NameIdentifier).Value);
            return RedirectToAction(nameof(Index));
        }

        private bool DistrictExists(int id)
        {
            return _context.District.Any(e => e.DistrictId == id);
        }
    }
}
