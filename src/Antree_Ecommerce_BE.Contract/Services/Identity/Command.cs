using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Identity;

public static class Command
{
    public record RegisterCommand(
        string Email, string Username, string Password,
        string FirstName, string LastName, string Phonenumber
    ) : ICommand;
    
    public record ForgotPasswordCommand(
        string Email
    ) : ICommand;
    
    public record ChangePasswordCommand(
        string Email,
        string NewPassword
    ) : ICommand;
    
    public record VerifyCodeCommand(
        string Email,
        string Code
    ) : ICommand;
    
    public record LogoutCommand(
        string UserAccount
    ) : ICommand;
    
    
}