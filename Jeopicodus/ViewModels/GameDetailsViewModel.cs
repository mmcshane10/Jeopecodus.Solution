using System.Collections.Generic;
using Jeopicodus.Models;

namespace Jeopicodus.ViewModels
{
    public class GameDetailsViewModel
    {
        public Dictionary<string, List<Question>> Questions { get; set; }
        public Game Game { get; set; }
        public string TeamName { get; set; }

        public string TeamId { get; set; }
        public List<string> Categories { get; set; }
        public List<string> TeamNames { get; set; }

        public string ActiveTeam { get; set; }
    }
}