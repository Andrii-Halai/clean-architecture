namespace CleanArchitecture.Domain.Common;

public sealed class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message)
    {
    }
}

