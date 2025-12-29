using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL.Abstract
{
    public interface IYetkiDal : IDalVeriCekme<Yetki>, IDalVeriOlusturma<Yetki>, IDalVeriGunceleme<Yetki>
    {
    }
}
