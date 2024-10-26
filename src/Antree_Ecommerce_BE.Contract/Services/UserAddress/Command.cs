using System.ComponentModel;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Swashbuckle.AspNetCore.Annotations;

namespace Antree_Ecommerce_BE.Contract.Services.UserAddress;

public class Command
{
    public record CreateUserAddressCommand : ICommand
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid UserId { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
    }
    
    public record UpdateUserAddressCommand : ICommand
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid UserId { get; set; } 
        public Guid UserAddressId { get; set; } 
    }
}