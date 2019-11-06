using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jeopicodus.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                List<Game> games = _db.Games.Where(game => game.Status != GameStatus.GAME_OVER).ToList();
                List<Team> teams = _db.Teams.ToList();
                for(int i = 0; i < games.Count; i++)
                {
                    games[i].Teams = teams.Where(team => team.GameId == games[i].GameId).ToList();
                }
                var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var currentUser = await _userManager.FindByIdAsync(userId);
                GameIndexViewModel model = new GameIndexViewModel() { Games = games, User = currentUser };
                return View(model);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        [Authorize]
        [Route("Game/Details/{id}")]
        public async Task<ActionResult> Details(int id)
        {
            Game thisGame = _db.Games.Include(game => game.Teams).ThenInclude(team => team.Users).FirstOrDefault(game => game.GameId == id);
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var teamCount = 1;
            foreach(Team team in thisGame.Teams)
            {
                if(teamCount == 1)
                {
                    teamCount++;
                    team.IsTurn = true;
                }
                else
                {
                    team.IsTurn = false;
                }
                _db.Entry(team).State = EntityState.Modified;
                _db.SaveChanges();
                List<string> users = team.Users.Select(u => u.ApplicationUserId).ToList();
                if(users.Contains(userId))
                {
                    currentUser.TeamName = team.TeamName;
                }
            }

            List<Question> questionList = Game.Questions;
            Dictionary<string,List<Question>> questions = new Dictionary<string, List<Question>>();
            foreach(Question q in questionList)
            {
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

            GameDetailsViewModel model = new GameDetailsViewModel(){UserTeam = currentUser.TeamName, Game = thisGame, Questions = questions, Categories = categories};
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}