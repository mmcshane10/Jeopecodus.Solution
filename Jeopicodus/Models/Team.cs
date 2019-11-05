using System.Collections.Generic;

namespace Jeopicodus.Models
{
    public class Team
    {
        public bool IsFirst { get; set; }
        public string TeamName { get; set; }
        public virtual IEnumerable<ApplicationUser> Users { get; set; }
    }
}