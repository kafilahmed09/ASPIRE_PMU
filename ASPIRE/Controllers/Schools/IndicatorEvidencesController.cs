using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPIRE.Data;
using ASPIRE.Models.Domain.Schools;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ASPIRE.Controllers.Schools
{
    public class IndicatorEvidencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IndicatorEvidencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IndicatorEvidences
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.indicatorEvidence.Include(i => i.Indicator).Include(i => i.School);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult ListOfImages(int SchoolId, int IndicatorId, int FileTypeId)
        {
            ViewBag.SchoolId = SchoolId;
            ViewBag.IndicatorId = IndicatorId;
            ViewBag.FileTypeId = FileTypeId;
            return View();
        }
        public IActionResult ListOfVideos(int SchoolId, int IndicatorId, int FileTypeId)
        {
            ViewBag.SchoolId = SchoolId;
            ViewBag.IndicatorId = IndicatorId;
            ViewBag.FileTypeId = FileTypeId;
            return View();
        }
        public async Task<IActionResult> RefreshListOfImages(int SchoolId, int IndicatorId, int FileTypeId)
        {
            var applicationDbContext = _context.indicatorEvidence.Where(a=>a.SchoolId == SchoolId && a.IndicatorId == IndicatorId && a.FileTypeId == FileTypeId);
            return PartialView(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> RefreshListOfVideos(int SchoolId, int IndicatorId, int FileTypeId)
        {
            var applicationDbContext = _context.indicatorEvidence.Where(a => a.SchoolId == SchoolId && a.IndicatorId == IndicatorId && a.FileTypeId == FileTypeId);
            return PartialView(await applicationDbContext.ToListAsync());
        }
        public async Task<JsonResult> UploadEvidence(int IndicatorId, int SchoolId, IFormFile Attachment, string VideoLink, int FileTypeId)
        {
            if (ModelState.IsValid)
            {
                IndicatorEvidence indicatorEvidence = new IndicatorEvidence();
                indicatorEvidence.IndicatorId = IndicatorId;
                indicatorEvidence.DateOfUpload = DateTime.Today;
                indicatorEvidence.SchoolId = SchoolId;
                indicatorEvidence.FileTypeId = FileTypeId;
                if (FileTypeId == 3)
                {
                    indicatorEvidence.ImageURL = VideoLink;
                }
                else if (Attachment != null && Attachment.Length > 0)
                {                    
                    var rootPath = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot\\Documents\\SchoolId" + SchoolId.ToString() + "\\" + IndicatorId.ToString() + "_" + FileTypeId.ToString() + "\\");
                    string fileName = Path.GetFileName(Attachment.FileName);                    
                    Random random = new Random();
                    int randomNumber = random.Next(1, 1000);
                    fileName = "Evidence" + randomNumber.ToString() + fileName.Substring(fileName.LastIndexOf('.'));
                    indicatorEvidence.ImageURL = Path.Combine("/Documents/SchoolId" + SchoolId.ToString() + "/" + IndicatorId.ToString() + "_" + FileTypeId.ToString() + "/" + fileName);//Server Path
                    string sPath = Path.Combine(rootPath);
                    if (!System.IO.Directory.Exists(sPath))
                    {
                        System.IO.Directory.CreateDirectory(sPath);
                    }
                    string FullPathWithFileName = Path.Combine(sPath, fileName);
                    using (var stream = new FileStream(FullPathWithFileName, FileMode.Create))
                    {
                        await Attachment.CopyToAsync(stream);
                    }
                    //-----------------------------------                   
                }
                _context.Add(indicatorEvidence);
                await _context.SaveChangesAsync();
                return Json(new { isValid = true, message = "Successfully Uploaded!" });
            }
            return Json(new { isValid = false, message = "Failed to Upload!" });
        }
        public async Task<JsonResult> RemoveEvidence(int id)
        {
            var evidence = _context.indicatorEvidence.Find(id);
            if (evidence != null)
            {
                _context.indicatorEvidence.Remove(evidence);
                await _context.SaveChangesAsync();
                //-----------------------------------------------------------
            }
            else
            {
                return Json(new { isValid = false, message = "Failed to delete!" });
            }
            return Json(new { isValid = true, message = "Evidence has been successfully deleted" });
        }
        // GET: IndicatorEvidences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indicatorEvidence = await _context.indicatorEvidence.FindAsync(id);
            if (indicatorEvidence == null)
            {
                return NotFound();
            }
            ViewData["IndicatorId"] = new SelectList(_context.Indicator, "IndicatorId", "IndicatorId", indicatorEvidence.IndicatorId);
            ViewData["SchoolId"] = new SelectList(_context.School, "SchoolId", "SchoolId", indicatorEvidence.SchoolId);
            return View(indicatorEvidence);
        }

        // POST: IndicatorEvidences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IndicatorEvidenceId,IndicatorId,SchoolId,ImageURL,DateOfUpload,IsVerified,VerifiedBy,VerifiedDate")] IndicatorEvidence indicatorEvidence)
        {
            if (id != indicatorEvidence.IndicatorEvidenceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indicatorEvidence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndicatorEvidenceExists(indicatorEvidence.IndicatorEvidenceId))
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
            ViewData["IndicatorId"] = new SelectList(_context.Indicator, "IndicatorId", "IndicatorId", indicatorEvidence.IndicatorId);
            ViewData["SchoolId"] = new SelectList(_context.School, "SchoolId", "SchoolId", indicatorEvidence.SchoolId);
            return View(indicatorEvidence);
        }      

        private bool IndicatorEvidenceExists(int id)
        {
            return _context.indicatorEvidence.Any(e => e.IndicatorEvidenceId == id);
        }
    }
}
