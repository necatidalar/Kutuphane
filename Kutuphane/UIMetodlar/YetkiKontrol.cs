using Kutuphane.DAL.Contexes;

namespace Kutuphane.UI.UIMetodlar
{
    public class YetkiKontrol
    {
        private readonly KutuphaneDbContext _context;

        public YetkiKontrol(KutuphaneDbContext context)
        {
            _context = context;
        }

        public HashSet<string> GetUserPermissions(int personelId)
        {
            return _context.PersonelRolleri
                .Where(pr => pr.PersonelId == personelId)
                .Join(_context.RolYetkileri,
                      pr => pr.RolId,
                      ry => ry.RolId,
                      (pr, ry) => ry.Yetki.YetkiKodu)
                .Distinct()
                .ToHashSet();
        }
    }
}
