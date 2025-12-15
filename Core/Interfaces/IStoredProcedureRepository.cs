using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IStoredProcedureRepository
    {
        IDataResult<List<T>> ExecuteStoredProcedure<T>(string functionName, params object[] parameters) where T : class, IDto, new();
        IResult ExecuteStoredProcedureNoReturn(string spName, params object[] parameters);
    }
}
