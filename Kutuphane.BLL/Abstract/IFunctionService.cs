

using Core.Entity;
using Core.Utility.Results;

namespace Kutuphane.BLL.Abstract
{
    public interface IFunctionService
    {
        IDataResult<List<T>> ExecuteTableFunctionService<T>(string functionName, params object[] parameters) where T : class, IDto, new();
        IDataResult<T> ExecuteScalarFunctionService<T>(string functionName, params object[] parameters);
    }
}
