﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
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

        public ActionResult LoginPage()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }

        public ActionResult SignupPage()
        {
            ViewBag.Message = "Your signup page.";

            return View();
        }

        public ActionResult ProfilePage()
        {
            ViewBag.Message = "Your profile page.";

            return View();
        }
    }
}