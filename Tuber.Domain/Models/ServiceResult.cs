namespace Tuber.Domain.Models;
public class ServiceResult<T> where T : new()
{
    //  Valid Service result
    public ServiceResult(T payload)
    {
        IsSuccess = true;
        Payload = payload;
        Exceptions = new List<Exception>();
    }

    //  Invalid Service Result with one exception
    public ServiceResult(T payload, Exception exception)
    {
        IsSuccess = false;
        Payload = payload;
        Exceptions = new List<Exception>() { exception };
    }

    //  Invalid Service result with multiple exceptions
    public ServiceResult(T payload, List<Exception> exceptionList)
    {
        IsSuccess = false;
        Payload = payload;
        Exceptions = exceptionList;
    }


    public bool IsSuccess { get; private init; }
    public bool HasFailed => !IsSuccess;
    public List<Exception> Exceptions { get; private init; }
    public T Payload { get; private init; }
}
