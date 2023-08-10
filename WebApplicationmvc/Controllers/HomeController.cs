﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplicationmvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult students()
        {
            ViewBag.Message = "Your s page.";

            return View();
        }

        public ActionResult lgn()
        {
            ViewBag.Message = "Login";

            return View();
        }

        public ActionResult sign()
        {
            ViewBag.Message = "SignUP.";

            return View();
        }

    }
}