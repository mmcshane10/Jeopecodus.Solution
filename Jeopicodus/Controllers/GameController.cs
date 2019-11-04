using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jeopicodus.Models;

namespace Jeopicodus.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult Details()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}