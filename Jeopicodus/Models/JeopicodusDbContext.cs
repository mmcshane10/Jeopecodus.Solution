using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jeopicodus
{
    public class JeopicodusContext : IdentityDbContext<ApplicationUser>
    {
        public JeopicodusContext(DbContextOptions options) : base(options) { }
    }
}