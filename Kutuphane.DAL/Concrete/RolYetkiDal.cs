using Core.DataAccess.Repository;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;

namespace Kutuphane.DAL.Concrete
{
    public class RolYetkiDal
    : EfRepositoryBase<RolYetki, KutuphaneDbContext>, IRolYetkiDal
    {
    }
}
