using System.Collections.Generic;

namespace Jeopicodus.Models
{
    public class TeamMember
    {
        public int TeamMemberId { get; set; }
        public int TeamId { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
