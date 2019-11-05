using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jeopicodus.Models;
using System.Collections.Generic;
using System.Linq;

namespace Jeopicodus.Controllers
{
    public class GameController : Controller
    {

        private JeopicodusContext _db;
        public GameController(JeopicodusContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                List<Game> games = _db.Games.Where(game => game.Status != GameStatus.GAME_OVER).ToList();
                return View(games);
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