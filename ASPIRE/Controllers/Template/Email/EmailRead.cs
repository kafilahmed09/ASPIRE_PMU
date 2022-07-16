﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Email
{
    [AllowAnonymous]
    public class EmailRead : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("email-read")]
        public ActionResult emailread()
        {
            return View();
        }
    }
}
