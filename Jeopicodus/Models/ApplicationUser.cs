using Microsoft.AspNetCore.Identity;

namespace Jeopicodus.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int GameReference { get; set; }
        public string TeamName { get; set; }
        public string ConnectionId { get; set; }
        public ApplicationUser()
        {
            GameReference = 0;
        }
    }
}