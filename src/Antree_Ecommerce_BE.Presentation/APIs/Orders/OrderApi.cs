using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Extensions;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Antree_Ecommerce_BE.Presentation.Constrants;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Orders;

using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Orders.Command;
using QueryV1 = Antree_Ecommerce_BE.Contract.Services.Orders.Query;

public class OrderApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/orders";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Orders")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, GetOrdersV1)
            .RequireAuthorization(RoleNames.CustomerAndSeller);
        group1.MapGet("vnpay-callback", VnPayCallBackV1);
        group1.MapPost(string.Empty, CreateOrdersV1).RequireAuthorization(RoleNames.Customer);
        // group1.MapDelete("{orderId}", () => { });
        // group1.MapPut("{orderId}", () => { });
    }
    
    public static async Task<IResult> CreateOrdersV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService, [FromBody] CommandV1.CreateOrderCommand request)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var UserId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        var result = await sender.Send(new CommandV1.CreateOrderCommand()
        {
            OrderItems = request.OrderItems,
            UserId = new Guid(UserId)
        });
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> GetOrdersV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService,
        string? sortColumn = null,
        string? sortOrder = null,
        bool notFeedback = false,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var role = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "Role")!.Value;
        Result result;

        if (role.Equals("0"))
        {
            var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
            result = await sender.Send(new QueryV1.GetCustomerOrdersQuery(
                new Guid(userId), notFeedback, sortColumn,
                SortOrderExtension.ConvertStringToSortOrder(sortOrder),
                pageIndex, pageSize
            ));
        }
        else
        {
            var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;
            result = await sender.Send(new QueryV1.GetVendorOrdersQuery(
                new Guid(vendorId), notFeedback, sortColumn,
                SortOrderExtension.ConvertStringToSortOrder(sortOrder),
                pageIndex, pageSize
            ));
        }
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    
    public static async Task<IResult> VnPayCallBackV1(ISender sender, string vnp_Amount, string vnp_BankCode, string vnp_BankTranNo,
    string vnp_CardType, string vnp_OrderInfo, string vnp_PayDate, string vnp_ResponseCode, string vnp_TmnCode, string vnp_TransactionNo,
    string vnp_TransactionStatus, string vnp_TxnRef, string vnp_SecureHash)
    {

        Dictionary<string, string> vnpayData = new Dictionary<string, string>
        {
            { "vnp_Amount", vnp_Amount },
            { "vnp_BankCode", vnp_BankCode },
            { "vnp_BankTranNo", vnp_BankTranNo },
            { "vnp_CardType", vnp_CardType },
            { "vnp_OrderInfo", vnp_OrderInfo },
            { "vnp_PayDate", vnp_PayDate },
            { "vnp_ResponseCode", vnp_ResponseCode },
            { "vnp_TmnCode", vnp_TmnCode },
            { "vnp_TransactionNo", vnp_TransactionNo },
            { "vnp_TransactionStatus", vnp_TransactionStatus },
            { "vnp_TxnRef", vnp_TxnRef },
            { "vnp_SecureHash", vnp_SecureHash }
        };
        var result = await sender.Send(new CommandV1.VerifyOrderCommand(vnpayData));
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok();
    }
}