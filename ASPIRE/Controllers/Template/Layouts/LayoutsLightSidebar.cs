﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Layouts
{
    [AllowAnonymous]
    public class LayoutsLightSidebar : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("layout-light-sidebar")]
        public ActionResult layoutlightsidebar()
        {
            TempData["ModeName"] = Contants.LAYOUT_LIGHT_SIDEBAR;
            TempData["WelcomeText"] = "LAYOUT_LIGHT_SIDEBAR";
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
