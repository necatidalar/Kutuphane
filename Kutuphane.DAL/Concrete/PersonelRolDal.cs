using Core.DataAccess.Repository;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL.Concrete
{
    public class PersonelRolDal : EfRepositoryBase<PersonelRol, KutuphaneDbContext>, IPersonelRolDal
    {
    }
}
