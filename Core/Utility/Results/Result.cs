namespace Core.Utility.Results
{
    public class Result : IResult
    {

        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            Message = message;
        }
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public string Message { get; }

        public bool IsSuccess { get; }
    }
}