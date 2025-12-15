

using Core.Entity;
using Core.Utility.Results;

namespace Kutuphane.BLL.Abstract
{
    public interface IStoredProcedureService
    {
        IDataResult<List<T>> ExecuteStoredProcedureService<T>(string functionName, params object[] parameters) where T : class, IDto, new();
        IResult ExecuteStoredProcedureNoReturnService(string spName, params object[] parameters);
    }
}
