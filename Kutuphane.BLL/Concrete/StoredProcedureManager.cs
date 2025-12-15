

using Core.Entity;
using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;

namespace Kutuphane.BLL.Concrete
{
    public class StoredProcedureManager : IStoredProcedureService
    {
        private readonly IStoredProcedureDal _iDal;

        public StoredProcedureManager(IStoredProcedureDal iDal)
        {
            _iDal = iDal;
        }

        public IResult ExecuteStoredProcedureNoReturnService(string spName, params object[] parameters)
        {
            return _iDal.ExecuteStoredProcedureNoReturn(spName, parameters);
        }

        public IDataResult<List<T>> ExecuteStoredProcedureService<T>(string functionName, params object[] parameters) where T : class, IDto, new()
        {
            return _iDal.ExecuteStoredProcedure<T>(functionName, parameters);
        }
    }
}
