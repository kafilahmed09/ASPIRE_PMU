﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Charts
{
    [AllowAnonymous]
    public class ChartsSparkline : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("charts-sparkline")]
        public ActionResult chartssparkline()
        {
            return View();
        }
    }
}
