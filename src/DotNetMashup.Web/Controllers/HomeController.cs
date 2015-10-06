﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetMashup.Web.Repositories;
using Microsoft.AspNet.Mvc;

namespace DotNetMashup.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogPostRepository factory;

        public HomeController(BlogPostRepository factory)
        {
            this.factory = factory;
        }

        public IActionResult Index()
        {
            var data = factory.GetData();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}