using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace Jeopicodus.Models
{
    public class PlayHub : Hub
    {
        private readonly JeopicodusContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlayHub(JeopicodusContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public void JoinHub(string playerId)
        {
            if (_userManager.Users.FirstOrDefault(player => player.ConnectionId == Context.ConnectionId) == null)
            {
                var currentPlayer = _userManager.Users.FirstOrDefault(player => player.Id == playerId);
                currentPlayer.ConnectionId = Context.ConnectionId;
                _db.Entry(currentPlayer).State = EntityState.Modified;
                _db.SaveChanges();
            }
        }

    }
}