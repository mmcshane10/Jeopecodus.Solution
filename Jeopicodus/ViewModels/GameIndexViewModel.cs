using System.Collections.Generic;
using Jeopicodus.Models;

namespace Jeopicodus.ViewModels
{
    public class GameIndexViewModel
    {
        public List<Game> Games { get; set; }
        public ApplicationUser User { get; set; }
    }
}