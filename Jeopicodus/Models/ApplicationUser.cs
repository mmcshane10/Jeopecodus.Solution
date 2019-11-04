using Microsoft.AspNetCore.Identity;

namespace Jeopicodus.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Team { get; set; }
    }
}