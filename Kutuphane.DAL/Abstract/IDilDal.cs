using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL.Abstract
{
    public interface IDilDal : IDalVeriCekme<Dil>, IDalVeriOlusturma<Dil>, IDalVeriGunceleme<Dil>
    {
    }
}