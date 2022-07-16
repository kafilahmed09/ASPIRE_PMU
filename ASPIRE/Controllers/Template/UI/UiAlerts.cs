﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.UI
{
    [AllowAnonymous]
    public class UiAlerts : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ui-alerts")]
        public ActionResult uialerts()
        {
            return View();
        }
        
    }
}
