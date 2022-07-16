using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ASPIRE.Data;
using ASPIRE.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Controllers
{
    //[AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {         
            var resultSummary = await _context.IndicatorwiseSummary.ToListAsync();
            ViewBag.Solar_Target = resultSummary.Sum(a=>a.Solar_Target);
            ViewBag.Solar_GRN = resultSummary.Sum(a=>a.Solar_GRN);
         
            ViewBag.IT_Target = resultSummary.Sum(a=>a.IT_Target);
            ViewBag.IT_GRN = resultSummary.Sum(a=>a.IT_GRN);

            ViewBag.Learn_Target = 313;// resultSummary.Sum(a=>a.Learn_Target);
            ViewBag.Learn_GRN = resultSummary.Sum(a=>a.Learn_GRN);

            ViewBag.Science_Target = 120;// resultSummary.Sum(a=>a.Science_Target);
            ViewBag.Science_GRN = resultSummary.Sum(a=>a.Science_GRN);

            ViewBag.Hygiene_Target = 895;// resultSummary.Sum(a=>a.Hygiene_Target);
            ViewBag.Hygiene_GRN = resultSummary.Sum(a=>a.Hygiene_GRN);

            ViewBag.MHM_Target = 384;// resultSummary.Sum(a=>a.MHM_Target);
            ViewBag.MHM_GRN = resultSummary.Sum(a=>a.MHM_GRN);

            ViewBag.Internet_Target = 180;// resultSummary.Sum(a=>a.Internet_Target);
            ViewBag.Internet_GRN = resultSummary.Sum(a=>a.Internet_GRN);
            return View();
        }
        public IActionResult Index2()
        {           
            return View();
        }
        public IActionResult Graph(string year)
        {           
            return PartialView();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}