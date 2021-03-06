﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult CV()
        {
            string fileName = "~/Content/CV_Oskar_Kogut.pdf";
            return File(fileName, "application/pdf");
        }

        public ActionResult Unity()
        {
            return View();
        }

        public ActionResult Wpf()
        {
            return View();
        }

        public ActionResult Xamarin()
        {
            return View();
        }

        public ActionResult Android()
        {
            return View();
        }
    }
}