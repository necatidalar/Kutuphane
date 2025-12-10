using Core.DataAccess.Repository;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.DAL.Concrete
{
    public class YayineviDal<TContext> : EfRepositoryBase<Yayinevi, TContext>, IYayineviDal
        where TContext : DbContext, new()
    {
    }
}
