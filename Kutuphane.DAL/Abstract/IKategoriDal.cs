using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL.Abstract
{
    public interface IKategoriDal : IDalVeriCekme<Kategori>, IDalVeriOlusturma<Kategori>, IDalVeriGunceleme<Kategori>
    {
    }
}
