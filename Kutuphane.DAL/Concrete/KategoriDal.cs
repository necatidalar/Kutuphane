using Core.DataAccess.Repository;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.DAL.Concrete
{
    public class KategoriDal<TContext> : EfRepositoryBase<Kategori, TContext>, IKategoriDal
        where TContext : DbContext, new()
    {
<<<<<<< Updated upstream
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
=======
        
>>>>>>> Stashed changes
    }
}
