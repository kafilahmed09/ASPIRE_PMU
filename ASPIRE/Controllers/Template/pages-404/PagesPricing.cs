﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.pages_404
{
    [AllowAnonymous]
    public class PagesPricing : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("pages-pricing")]
        public ActionResult pagespricing()
        {
            return View();
        }
    }
}
