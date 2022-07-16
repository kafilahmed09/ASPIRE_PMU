﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Layouts
{
    [AllowAnonymous]
    public class LayoutsScrollable : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
