﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Auth
{
    [AllowAnonymous]
    public class AuthLogin2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
