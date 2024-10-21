using Microsoft.AspNetCore.SignalR;

namespace Antree_Ecommerce_BE.Application.SignalR;

public class PaymentHub : Hub
{
    // Clients will call this to join a group based on an identifier (e.g., orderId)
    public async Task JoinGroup(string groupId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupId);
        Console.WriteLine($"Client {Context.ConnectionId} joined group {groupId}");
    }

    // Clients will call this to leave the group when necessary
    public async Task LeaveGroup(string groupId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupId);
        Console.WriteLine($"Client {Context.ConnectionId} left group {groupId}");
    }
    
    public string GetConnectionId()
    {
        return Context.ConnectionId;
    }

    public override async Task OnConnectedAsync()
    {
        Console.WriteLine($"Client connected: {Context.ConnectionId}");
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
        Console.WriteLine($"Client disconnected: {Context.ConnectionId}. Reason: {exception?.Message}");
        await base.OnDisconnectedAsync(exception);
    }
}