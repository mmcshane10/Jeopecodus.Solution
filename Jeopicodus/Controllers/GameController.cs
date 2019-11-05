using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jeopicodus.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Jeopicodus.ViewModels;
using System;

namespace Jeopicodus.Controllers
{
    public class GameController : Controller
    {

        private JeopicodusContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public GameController(JeopicodusContext db, UserManager<ApplicationUser> userManager) 
        {
            _db = db;
            _userManager = userManager;
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

        [Authorize]
        public async Task<ActionResult> Details(int id)
        {
            Game thisGame = _db.Games.FirstOrDefault(game => game.GameId == id);

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            string teamName = currentUser.TeamName;

            List<Question> questionList = Game.Questions();
            Dictionary<string,List<Question>> questions = new Dictionary<string, List<Question>>();
            foreach(Question q in questionList)
            {
                Console.WriteLine(q.Id);
                if(!questions.Keys.Contains(q.Category + "_" + q.Difficulty))
                {
                    questions.Add(q.Category + "_" + q.Difficulty, new List<Question>{q});
                }
                else
                {
                    List<Question> list = questions[q.Category + "_" + q.Difficulty];
                    list.Add(q);
                }
            }

            List<string> categories = questionList.Select(q => q.Category).Distinct().ToList();

            while(categories.Count > 5)
            {
                Random rand = new Random();
                int indexToRemove = rand.Next(0, categories.Count);
                categories.Remove(categories[indexToRemove]);
            }

            GameDetailsViewModel model = new GameDetailsViewModel(){UserTeam = teamName, Game = thisGame, Questions = questions, Categories = categories};
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}