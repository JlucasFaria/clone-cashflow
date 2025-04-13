using System.Net;

namespace CashFlow.Exception.ExceptionsBase;
public class ErrorOnValidantionExcepition : CashFlowException
{
    private readonly List<string> _errors;

    public override int StatusCode => (int)HttpStatusCode.BadRequest;

    public ErrorOnValidantionExcepition(List<string> errorMessages) : base(string.Empty)
    {
        _errors = errorMessages;
    }

    public override List<string> GetErrors()
    {
        return _errors; 
    }
}
