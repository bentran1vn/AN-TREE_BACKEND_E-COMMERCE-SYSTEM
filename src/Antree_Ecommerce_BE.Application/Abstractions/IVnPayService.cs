using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Antree_Ecommerce_BE.Application.Abstractions;

public interface IVnPayService
{
    string CreatePaymentUrl(Order model);

    Task<(bool IsValid, string Message)> ValidateCallback(Dictionary<string, string> vnpayData);
}