﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColinWerra.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult ExceptionTest()
        {
            throw new Exception("An exceptional exception.");
        }
    }
}