﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Ecommerce
{
    [AllowAnonymous]
    public class EcommerceCart : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ecommerce-cart")]
        public ActionResult ecommercecart()
        {
            return View();
        }
    }
}
