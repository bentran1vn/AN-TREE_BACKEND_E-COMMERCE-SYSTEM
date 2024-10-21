using System.ComponentModel;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Antree_Ecommerce_BE.Contract.Services.Vendors;

public static class Command
{
    public record VerifyVendorCommand(Guid VendorId, bool IsAccepted) : ICommand;
    
    public record CreateVendorCommand : ICommand
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid? UserId { get; set; } 
        public string VendorEmail { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile AvatarImage { get; set; }
        public IFormFile CoverImage { get; set; }
        public string BankName { get; set; }
        public string BankOwnerName { get; set; }
        public string BankAccountNumber { get; set; }
    }
    
    public record UpdateVendorCommand : ICommand
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13423f76f")]
        public Guid? VendorId { get; set; } 
        public string? VendorEmail { get; set; }
        public string? VendorName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? PhoneNumber { get; set; }
        public IFormFile? AvatarImage { get; set; }
        public IFormFile? CoverImage { get; set; }
        public string? BankName { get; set; }
        public string? BankOwnerName { get; set; }
        public string? BankAccountNumber { get; set; }
    }
    
    public record ConfirmUpdateVendorCommand : ICommand
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13423f76f")]
        public Guid UserId { get; set; } 
        public string? VendorEmail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BankName { get; set; }
        public string? BankOwnerName { get; set; }
        public string? BankAccountNumber { get; set; }
        public string VerifyCode { get; set; }
    }
    
    public record DeleteVendorCommand(Guid UserId) : ICommand;
}