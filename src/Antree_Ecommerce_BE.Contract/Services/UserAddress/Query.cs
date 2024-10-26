using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;

namespace Antree_Ecommerce_BE.Contract.Services.UserAddress;

public class Query
{
    public record GetAllUserAddressQuery(Guid UserId) : IQuery<List<Response.GetAllUserAddress>>;
}