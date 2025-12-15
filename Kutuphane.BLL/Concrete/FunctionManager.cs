

using Core.Entity;
using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;

namespace Kutuphane.BLL.Concrete
{
    public class FunctionManager : IFunctionService
    {
        private readonly IFunctionDal _iDal;

        public FunctionManager(IFunctionDal iDal)
        {
            _iDal = iDal;
        }

        public IDataResult<T> ExecuteScalarFunctionService<T>(string functionName, params object[] parameters) 
        {
            return _iDal.ExecuteScalarFunction<T>(functionName, parameters);
        }

        public IDataResult<List<T>> ExecuteTableFunctionService<T>(string functionName, params object[] parameters) where T : class, IDto, new()
        {
            return _iDal.ExecuteTableFunction<T>(functionName, parameters);
        }
    }
}
