using Core.Entity;
using Core.Utility.Results;
using System.Data;

namespace Core.Interfaces
{
    public interface IStoredProcedureRepository
    {
        IDataResult<List<T>> ExecuteStoredProcedure<T>(string functionName, params object[] parameters) where T : class, IDto, new();
        IDataResult<DataTable> ExecuteStoredProcedureDataTable(string spName, params object[] parameters);
        IResult ExecuteStoredProcedureNoReturn(string spName, params object[] parameters);
    }
}
