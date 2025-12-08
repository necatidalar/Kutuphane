namespace Core.Utility.Results
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
