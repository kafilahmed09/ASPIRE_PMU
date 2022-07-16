﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Calendar
{
    [AllowAnonymous]
    public class Calendar : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
