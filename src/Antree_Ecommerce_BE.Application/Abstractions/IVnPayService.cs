using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Antree_Ecommerce_BE.Application.Abstractions;

public interface IVnPayService
{
    string CreatePaymentUrl(Order model);
    Order PaymentExecute(IQueryCollection collections);
}