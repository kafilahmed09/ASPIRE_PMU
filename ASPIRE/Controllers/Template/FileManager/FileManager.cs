﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.FileManager
{
    [AllowAnonymous]
    public class FileManager : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
