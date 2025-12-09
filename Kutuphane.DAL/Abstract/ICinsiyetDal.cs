using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface ICinsiyetDal : IDalVeriCekme<Cinsiyet>, IDalVeriOlusturma<Cinsiyet>, IDalVeriGunceleme<Cinsiyet>
    {
        
    }
}
