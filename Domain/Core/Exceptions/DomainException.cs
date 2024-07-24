using Domain.Core.BaseType;

namespace Domain.Core.Exceptions;

public class DomainException : Exception
{
    public DomainException(Error error) : base(error.Code, new Exception(error.Message))
    {
        
    }
}
