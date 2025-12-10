using Core.DataAccess.Repository;
using Core.Utility.Results;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Concrete
{
    public class KategoriDal : EfRepositoryBase<Kategori, KutuphaneDbContext>, IKategoriDal
    {
        public IDataResult<List<Kategori>> KategoriListeDetayliGetir(Expression<Func<Kategori, bool>>? predicate = null)
        {
            try
            {
                using var db = new KutuphaneDbContext();
                var dto = db.Set<Kategori>()
                    .Include(c => c.KitapKategoriler)
                    .Where(predicate ?? (x => true))
                    .Select(x => new Kategori
                    {
                        KategoriId = x.KategoriId,
                        KategoriAdi = x.KategoriAdi,
                        KitapKategoriler = x.KitapKategoriler,
                        AktifMi = x.AktifMi

                    }).ToList();
                return new SuccessDataResult<List<Kategori>>(dto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Kategori>>(e.Message);
            }
        }
    }
}
