﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Auth
{
    [AllowAnonymous]
    public class AuthRegister : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("auth-register")]
        public ActionResult authregister()
        {
            return View();
        }
    }
}
