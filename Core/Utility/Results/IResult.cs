

namespace Core.Utility.Results
{
    public interface IResult 
    {
        string Message { get; }
        bool IsSuccess { get; }
    }
}
