using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Jeopicodus.Models
{
    public class GameHub : Hub
    {
        public async Task Send(string teamName, string message)
        {
            await Clients.All.SendAsync("Send", teamName, message);
        }
    }
}