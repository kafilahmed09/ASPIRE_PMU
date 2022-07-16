using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPIRE.Data;
using ASPIRE.Models.Domain.MasterSetup;
using ASPIRE.Models.Domain.Schools;

namespace ASPIRE.Controllers.MasterSetup
{
    public class SchoolsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchoolsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schools
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.School.Include(s => s.UnionCouncil).Select(a=> new School { SchoolId = a.SchoolId, District = a.District, Tehsil = a.Tehsil, UC = a.UC, BEMISCode = a.BEMISCode, SchoolName = a.SchoolName, SchoolLevel = a.SchoolLevel });
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult SchoolProfile(int id)
        {
            ViewBag.Id = id;
            ViewBag.SchoolName = _context.School.Find(id).SchoolName;
            return View();
        }
        public IActionResult SchoolBasicInfo(int id)
        {
            var applicationDbContext = _context.School.Where(a=>a.SchoolId == id).Select(a => new School { SchoolId = a.SchoolId, District = a.District, Tehsil = a.Tehsil, UC = a.UC, BEMISCode = a.BEMISCode, SchoolName = a.SchoolName, SchoolLevel = a.SchoolLevel }).FirstOrDefault();
            return PartialView(applicationDbContext);
        }
        public async Task<IActionResult> SchoolGRNs(int id)
        {
            var applicationDbContext = _context.indicatorEvidence.Include(a=>a.Indicator).Where(a => a.SchoolId == id && a.FileTypeId == 1).Select(a => 
                new IndicatorEvidence { Indicator = a.Indicator, ImageURL = a.ImageURL});
            return PartialView(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> SchoolImages(int id)
        {
            var applicationDbContext = _context.indicatorEvidence.Include(a => a.Indicator).Where(a => a.SchoolId == id && a.FileTypeId == 2).Select(a =>
                  new IndicatorEvidence { Indicator = a.Indicator, ImageURL = a.ImageURL });
            return PartialView(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> SchoolVideos(int id)
        {
            var applicationDbContext = _context.indicatorEvidence.Include(a => a.Indicator).Where(a => a.SchoolId == id && a.FileTypeId == 3).Select(a =>
                  new IndicatorEvidence { Indicator = a.Indicator, ImageURL = a.ImageURL });
            return PartialView(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> UploadEvidence(int id)
        {
            ViewBag.Id = id;
            var applicationDbContext = _context.School.Include(s => s.UnionCouncil).Select(a => new School { SchoolId = a.SchoolId, District = a.District, Tehsil = a.Tehsil, UC = a.UC, BEMISCode = a.BEMISCode, SchoolName = a.SchoolName, SchoolLevel = a.SchoolLevel });
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult ListOfIndicator(int id, int FileType)
        {
            ViewBag.Id = id;
            ViewBag.FileTypeId = FileType;
            return View();
        }
        public async Task<IActionResult> RefreshListOfIndicator(int id, int FileTypeId)
        {
            ViewBag.Id = id;                                           
            ViewBag.FileTypeId = FileTypeId;                                           
            var applicationDbContext =
                from u in _context.Indicator 
                join p in _context.indicatorEvidence.Where(a=>a.SchoolId == id && a.FileTypeId == FileTypeId) on u.IndicatorId equals p.IndicatorId into gj
                from x in gj.DefaultIfEmpty()
                select new IndicatorEvidence
                {
                    Indicator = u,     
                    SchoolId = (x == null ? 0 : x.SchoolId),
                    IndicatorEvidenceId = (x == null ? 0 : x.IndicatorEvidenceId),
                    ImageURL = (x == null ? String.Empty : x.ImageURL),                                                          
                };
            return PartialView(await applicationDbContext.ToListAsync());
        }
        // GET: Schools/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School
                .Include(s => s.UnionCouncil)
                .FirstOrDefaultAsync(m => m.SchoolId == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        // GET: Schools/Create
        public IActionResult Create()
        {
            ViewData["UnionCouncilId"] = new SelectList(_context.UnionCouncil, "UnionCouncilId", "UnionCouncilId");
            return View();
        }

        // POST: Schools/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SchoolId,BEMISCode,SchoolName,SchoolLevel,Gender,Shift,IsFunctional,PakkaRoom,KachaRoom,District,Tehsil,SubTehsil,UC,WardName,WardNo,VillageName,NA,PA,ClusterBemisCode,ClusterName,ClusterDDOCode,SchoolContactNo,ClusterFeedingSchoolsPrimary,ClusterFeedingSchoolsMiddle,Location,Zone,YearofNonFunctinal,ReasonOfNonFunctional,IsDisableStudentsInSchool,IsRampforStudentsOrTeachers,IsBuilding,SchoolOwnedBy,BuildingStructure,BuildingCondition,IsSpaceForNewRooms,NoOfRoomsWithWindowsAndVantilation,IsProperSeverageSystem,IsWaterFacilityInToilets,IsBoundaryWall,BoundaryWallStructure,BoundaryWallCondition,IsPlayGround,IsElectricityInArea,IsElectricity,ElectricitySource,DistanceOfNearestPoll,IsGasInArea,IsGasInSchool,IsGovtDrinkingWaterScheme,IsDrinkingWaterAtSchool,SourceOfWater,IsWaterTank,DistanceOfNearestWaterSource,IsTelephoneAvailabe,IsFunctionStatusTelephone,ClosedReasonTelephone,IsInternetAvailabe,IsFunctionStatusInternet,ClosedReasonInternet,IsScienceLab,IsFunctionStatusScienceLab,IsComputerLab,IsLibraryAvailable,CleaningResponsibility,IsWashbasinAvailable,IsWaterforWashBasin,IsSoapForWashBasin,CleaningCycleOfWashBasin,IsTeacherUsesTeachingMeterialOnHealth,MajorDiseaseCauseForAbsentism,IsFirstaidKit,IsTrainingOnFirstAidKit,IsInspectionOfCleaning,IsSeprateRoomForECE,IsFullTimeTeacherForECE,IsTrendExtraCracularActivity,Activity1,IsAudioAndVideoEquipment,IsTeacherUsesAudioAndVideoEquipment,IsTrainingOnMHMKits,IsMHMKitsAtSchool,IsPTSMC,IsPTSMCParticipatedInAnyActivityCurrentYear,IsMeetingRecordesAvailable,IsChildOfPTSMCMembersAreEnrolled,IsAnySDPFormPTSMCLast3Years,IsExaminationHall,NumberOfVisitByEducationalManager,KachiBoys,KachiGirls,PakiBoys,PakiGirls,TwoBoys,TwoGirls,ThreeBoys,ThreeGirls,FourBoys,FourGirls,FiveBoys,FiveGirls,SixBoys,SixGirls,SevenBoys,SevenGilrs,EightBoys,EightGilrs,NineBoys,NineGirls,TenBoys,TenGirls,ElevenBoys,ElevenGirls,TwelveBoys,TwelveGilrs,TotalSchoolProfileStudent,TotalStudentProfileEntered,ContactPersonName,ContactNumber,IsSolarization,IsITLab,ChildrenReceivingDistanceLearningKits,IsInternetConnectivity,IsScienceLabEquipment,IsHygieneKit,IsLearningKit,IsMHMKit,SencTeaching,AppTeaching,TeachingMale,TeachingFemale,TotalTeachingStaff,SencNonTeaching,AppNonTeaching,NonteachingMale,NonteachingFemale,TotalNonTeachingStaff,VchCreatedBy,DtmCreatedDate,Total,KachaHMR,PakkaHMR,KachaClerkOffice,PakkaClerkOffice,KachaHall,PakkaHall,KachaStaffRoom,PakkaStaffRoom,KachaGuardRoom,PakkaGuardRoom,KachaToilet,KachaSportsRoom,PakkaToilet,PakkaSportsRoom,KachaResourceCenter,PakkaResourceCenter,UnionCouncilId")] School school)
        {
            if (ModelState.IsValid)
            {
                _context.Add(school);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UnionCouncilId"] = new SelectList(_context.UnionCouncil, "UnionCouncilId", "UnionCouncilId", school.UnionCouncilId);
            return View(school);
        }

        // GET: Schools/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School.FindAsync(id);
            if (school == null)
            {
                return NotFound();
            }
            ViewData["UnionCouncilId"] = new SelectList(_context.UnionCouncil, "UnionCouncilId", "UnionCouncilId", school.UnionCouncilId);
            return View(school);
        }

        // POST: Schools/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SchoolId,BEMISCode,SchoolName,SchoolLevel,Gender,Shift,IsFunctional,PakkaRoom,KachaRoom,District,Tehsil,SubTehsil,UC,WardName,WardNo,VillageName,NA,PA,ClusterBemisCode,ClusterName,ClusterDDOCode,SchoolContactNo,ClusterFeedingSchoolsPrimary,ClusterFeedingSchoolsMiddle,Location,Zone,YearofNonFunctinal,ReasonOfNonFunctional,IsDisableStudentsInSchool,IsRampforStudentsOrTeachers,IsBuilding,SchoolOwnedBy,BuildingStructure,BuildingCondition,IsSpaceForNewRooms,NoOfRoomsWithWindowsAndVantilation,IsProperSeverageSystem,IsWaterFacilityInToilets,IsBoundaryWall,BoundaryWallStructure,BoundaryWallCondition,IsPlayGround,IsElectricityInArea,IsElectricity,ElectricitySource,DistanceOfNearestPoll,IsGasInArea,IsGasInSchool,IsGovtDrinkingWaterScheme,IsDrinkingWaterAtSchool,SourceOfWater,IsWaterTank,DistanceOfNearestWaterSource,IsTelephoneAvailabe,IsFunctionStatusTelephone,ClosedReasonTelephone,IsInternetAvailabe,IsFunctionStatusInternet,ClosedReasonInternet,IsScienceLab,IsFunctionStatusScienceLab,IsComputerLab,IsLibraryAvailable,CleaningResponsibility,IsWashbasinAvailable,IsWaterforWashBasin,IsSoapForWashBasin,CleaningCycleOfWashBasin,IsTeacherUsesTeachingMeterialOnHealth,MajorDiseaseCauseForAbsentism,IsFirstaidKit,IsTrainingOnFirstAidKit,IsInspectionOfCleaning,IsSeprateRoomForECE,IsFullTimeTeacherForECE,IsTrendExtraCracularActivity,Activity1,IsAudioAndVideoEquipment,IsTeacherUsesAudioAndVideoEquipment,IsTrainingOnMHMKits,IsMHMKitsAtSchool,IsPTSMC,IsPTSMCParticipatedInAnyActivityCurrentYear,IsMeetingRecordesAvailable,IsChildOfPTSMCMembersAreEnrolled,IsAnySDPFormPTSMCLast3Years,IsExaminationHall,NumberOfVisitByEducationalManager,KachiBoys,KachiGirls,PakiBoys,PakiGirls,TwoBoys,TwoGirls,ThreeBoys,ThreeGirls,FourBoys,FourGirls,FiveBoys,FiveGirls,SixBoys,SixGirls,SevenBoys,SevenGilrs,EightBoys,EightGilrs,NineBoys,NineGirls,TenBoys,TenGirls,ElevenBoys,ElevenGirls,TwelveBoys,TwelveGilrs,TotalSchoolProfileStudent,TotalStudentProfileEntered,ContactPersonName,ContactNumber,IsSolarization,IsITLab,ChildrenReceivingDistanceLearningKits,IsInternetConnectivity,IsScienceLabEquipment,IsHygieneKit,IsLearningKit,IsMHMKit,SencTeaching,AppTeaching,TeachingMale,TeachingFemale,TotalTeachingStaff,SencNonTeaching,AppNonTeaching,NonteachingMale,NonteachingFemale,TotalNonTeachingStaff,VchCreatedBy,DtmCreatedDate,Total,KachaHMR,PakkaHMR,KachaClerkOffice,PakkaClerkOffice,KachaHall,PakkaHall,KachaStaffRoom,PakkaStaffRoom,KachaGuardRoom,PakkaGuardRoom,KachaToilet,KachaSportsRoom,PakkaToilet,PakkaSportsRoom,KachaResourceCenter,PakkaResourceCenter,UnionCouncilId")] School school)
        {
            if (id != school.SchoolId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(school);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolExists(school.SchoolId))
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
            ViewData["UnionCouncilId"] = new SelectList(_context.UnionCouncil, "UnionCouncilId", "UnionCouncilId", school.UnionCouncilId);
            return View(school);
        }

        // GET: Schools/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School
                .Include(s => s.UnionCouncil)
                .FirstOrDefaultAsync(m => m.SchoolId == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var school = await _context.School.FindAsync(id);
            _context.School.Remove(school);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolExists(int id)
        {
            return _context.School.Any(e => e.SchoolId == id);
        }
    }
}
