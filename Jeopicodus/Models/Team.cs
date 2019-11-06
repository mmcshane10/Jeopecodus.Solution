using System.Collections.Generic;

namespace Jeopicodus.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public int GameId { get; set; }
        public bool IsTurn { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }

        public Team()
        {
            Users = new HashSet<ApplicationUser>();
        }
    }
}