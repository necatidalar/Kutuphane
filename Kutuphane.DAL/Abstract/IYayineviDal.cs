using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL.Abstract
{
    public interface IYayineviDal : IDalVeriCekme<Yayinevi>, IDalVeriOlusturma<Yayinevi>, IDalVeriGunceleme<Yayinevi>
    {
    }
}
