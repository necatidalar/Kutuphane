using Core.DataAccess.Repository;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.DAL.Concrete
{
    public class YayineviDal: EfRepositoryBase<Yayinevi, KutuphaneDbContext>, IYayineviDal
    {
    }
}
