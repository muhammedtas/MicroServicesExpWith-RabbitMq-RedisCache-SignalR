using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Example_Hubs.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Example_Hubs.Hubs
{
    public class CustomHub : Hub
    {

        public async Task<string> ConnectGroup(string productName, string connectionId)
        {
            await Groups.AddToGroupAsync(connectionId, productName);
            return $"{connectionId} is added {productName}";
        }
        public Task PushNotify(Product productData)
        {
            return Clients.Group(productData.Name).SendAsync("ChangeProductValue", productData);
        }

        public async Task SendToAll(string user, string message)
        {
            await Clients.All.SendAsync("sendToAll", user, message);
        }
        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.SendAsync("ReceiveMessage", message);
        }

        public Task SendMessageToGroups(string message)
        {
            List<string> groups = new List<string>() { "SignalR Users" };
            return Clients.Groups(groups).SendAsync("ReceiveMessage", message);
        }

        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnConnectedAsync();
            // var name = Context.User.Identity.Name;
            // await Clients.All.SendAsync("onConnectedAsync", $"{Context.ConnectionId} joined");
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnDisconnectedAsync(exception);
        }
    }
}