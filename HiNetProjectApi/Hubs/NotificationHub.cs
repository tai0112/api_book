using Microsoft.AspNetCore.SignalR;

namespace HiNetProjectApi.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendToAll(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
        public async Task SenToUser(string userId, string message)
        {
            await Clients.User(userId).SendAsync("ReceiveMessage", message);
        }
    }
}

