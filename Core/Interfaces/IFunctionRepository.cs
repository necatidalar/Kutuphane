using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IFunctionRepository
    {
        IDataResult<List<T>> ExecuteTableFunction<T>(string functionName, params object[] parameters) where T : class, IDto, new();
        IDataResult<T> ExecuteScalarFunction<T>(string functionName, params object[] parameters) ;
    }

}
