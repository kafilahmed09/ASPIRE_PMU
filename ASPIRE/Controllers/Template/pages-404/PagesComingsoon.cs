using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.pages_404
{
    [AllowAnonymous]
    public class PagesComingsoon : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        [ActionName("pages-comingsoon")]
        public ActionResult pagescomingsoon()
        {
            return View();
        }
    }
}
