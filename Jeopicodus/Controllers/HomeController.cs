﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jeopicodus.Models;

namespace Jeopicodus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return View();
            }
            else{
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
