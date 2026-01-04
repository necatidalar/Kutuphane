using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IKitapDal : IDalVeriCekme<Kitap>, IDalVeriOlusturma<Kitap>, IDalVeriGunceleme<Kitap>
    {
        IDataResult<List<KitapDto>> KitapListeDetayliGetir(Expression<Func<Kitap, bool>>? predicate = null);
        IDataResult<List<OduncKitapDto>> OduncIcinListeGetir(Expression<Func<Kitap, bool>>? predicate = null);
    }
}
