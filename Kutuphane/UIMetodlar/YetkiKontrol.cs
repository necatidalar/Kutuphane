using Kutuphane.DAL.Contexes;

namespace Kutuphane.UI.UIMetodlar
{
    public class YetkiKontrol
    {
        private readonly KutuphaneDbContext _context;

        // Constructor'da DbContext'i alıyoruz
        public YetkiKontrol(KutuphaneDbContext context)
        {
            _context = context;
        }

        // Kullanıcıya ait yetkileri döndüren metot
        public List<string> GetUserPermissions(int personelId)
        {
            // Personelin sahip olduğu roller
            var personelRolleri = _context.PersonelRolleri
                .Where(pr => pr.PersonelId == personelId)
                .Select(pr => pr.RolId)
                .ToList();

            // Rollere ait yetkiler
            var yetkiler = _context.RolYetkileri
                .Where(ry => personelRolleri.Contains(ry.RolId))
                .Select(ry => ry.Yetki.YetkiKodu)
                .Distinct()
                .ToList();

            return yetkiler;
        }
    }
}
