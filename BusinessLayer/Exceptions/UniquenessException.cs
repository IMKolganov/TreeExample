namespace BusinessLayer.Exceptions;

public class UniquenessException : Exception
{
    public UniquenessException(string message) : base(message) { }
}