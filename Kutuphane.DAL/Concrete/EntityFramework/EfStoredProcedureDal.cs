using Core.DataAccess.Repository;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;

namespace Kutuphane.DAL.Concrete.EntityFramework
{
    public class EfStoredProcedureDal
        : EfStoredProcedureRepositoryBase<KutuphaneDbContext>, IStoredProcedureDal
    {
    }
}
