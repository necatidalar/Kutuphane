using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL.Abstract
{
    public interface IRolDal : IDalVeriCekme<Rol>, IDalVeriOlusturma<Rol>, IDalVeriGunceleme<Rol>
    {
    }
}
