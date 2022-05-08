namespace Demo.Ipt.Web.Core.Exceptions;
public class IptDomainException : Exception
{
    public IptDomainException()
    { }

    public IptDomainException(string message)
        : base(message)
    { }

    public IptDomainException(string message, Exception innerException)
        : base(message, innerException)
    { }
}
