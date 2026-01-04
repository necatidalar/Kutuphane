using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Contexes;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class PersonelRolDal : EfRepositoryBase<PersonelRol, KutuphaneDbContext>, IPersonelRolDal
    {
        public IDataResult<List<PersonelRolDto>> PersonelRolleriniGetir(Expression<Func<PersonelRol, bool>>? predicate)
        {
            try
            {
                using var db = new KutuphaneDbContext();

                var dto = db.Set<PersonelRol>()
                    .Include(x => x.Personel)
                    .Include(x => x.Rol)
                    .Where(predicate ?? (x => true))
                    .Select(x => new PersonelRolDto
                    {
                        PersonelRolId = x.PersonelId,
                        PersonelId = x.PersonelId,
                        PersonelAd = x.Personel.Ad,
                        PersonelSoyad = x.Personel.Soyad,
                        RolId = x.RolId,
                        RolAdi = x.Rol.RolAdi
                    })
                    .ToList();

                return new SuccessDataResult<List<PersonelRolDto>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<PersonelRolDto>>(e.Message);
            }
        }
    }
}
