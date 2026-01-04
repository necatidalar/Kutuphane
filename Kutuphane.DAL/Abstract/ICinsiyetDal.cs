using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.DAL.Abstract
{
    public interface ICinsiyetDal : IDalVeriCekme<Cinsiyet>, IDalVeriOlusturma<Cinsiyet>, IDalVeriGunceleme<Cinsiyet>
    {

    }
}
