using Microsoft.AspNetCore.Identity;

namespace Jeopicodus.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int GameId { get; set; }
        public string TeamName { get; set; }
    }
}