using Microsoft.AspNetCore.SignalR;

namespace Antree_Ecommerce_BE.Application.SignalR;

public class PaymentService
{
    private readonly IHubContext<PaymentHub> _hubContext;

    public PaymentService(IHubContext<PaymentHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task ProcessPayment(string orderId, bool isSuccess)
    {
        await _hubContext.Clients.Group(orderId).SendAsync("PaymentProcessed", isSuccess);
    }
}