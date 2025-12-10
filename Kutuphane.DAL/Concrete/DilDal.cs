using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class DilDal : EfRepositoryBase<Dil, KutuphaneDbContext>
    {
      
    }
}
