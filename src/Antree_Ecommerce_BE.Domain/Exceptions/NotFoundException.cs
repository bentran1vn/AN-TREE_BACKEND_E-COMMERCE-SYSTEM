namespace Antree_Ecommerce_BE.Domain.Exceptions;

public abstract class NotFoundException : DomainException
{
    protected NotFoundException(string message)
        : base("Not Found", message)
    {
    }
}