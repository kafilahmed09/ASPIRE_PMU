﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Auth
{
    [AllowAnonymous]
    public class AuthLockScreen : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("auth-lock-screen")]
        public ActionResult authlockscreen()
        {
            return View();
        }
    }
}
