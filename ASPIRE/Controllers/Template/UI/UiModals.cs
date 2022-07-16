﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.UI
{
    [AllowAnonymous]
    public class UiModals : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ui-modals")]
        public ActionResult uimodals()
        {
            return View();
        }
    }
}
