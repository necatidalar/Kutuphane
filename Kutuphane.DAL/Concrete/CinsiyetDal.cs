using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class CinsiyetDal : EfRepositoryBase<Cinsiyet, KutuphaneDbContext>, ICinsiyetDal
    {
        
    }
}
