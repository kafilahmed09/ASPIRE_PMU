﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Layouts
{
    [AllowAnonymous]
    public class LayoutsHoriScrollable : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
