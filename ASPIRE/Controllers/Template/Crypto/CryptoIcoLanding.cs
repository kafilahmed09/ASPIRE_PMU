﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Crypto
{
    [AllowAnonymous]
    public class CryptoIcoLanding : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("crypto-ico-landing")]
        public ActionResult cryptoicolanding()
        {
            return View();
        }
    }
}
