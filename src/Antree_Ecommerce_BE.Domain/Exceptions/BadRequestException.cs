namespace Antree_Ecommerce_BE.Domain.Exceptions;

public abstract class BadRequestException : DomainException
{
    protected BadRequestException(string message)
        : base("Bad Request", message)
    {
    }
}