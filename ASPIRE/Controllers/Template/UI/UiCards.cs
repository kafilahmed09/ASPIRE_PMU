﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.UI
{
    [AllowAnonymous]
    public class UiCards : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ui-cards")]
        public ActionResult uicards()
        {
            return View();
        }
    }
}
