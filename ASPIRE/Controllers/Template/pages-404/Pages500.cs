﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.pages_404
{
    [AllowAnonymous]
    public class Pages500 : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("pages-500")]
        public ActionResult pages500()
        {
            return View();
        }
    }
}