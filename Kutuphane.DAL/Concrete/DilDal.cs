using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class DilDal<TContext> : EfRepositoryBase<Dil, TContext>
        where TContext : DbContext, new()
    {
      
    }
}
