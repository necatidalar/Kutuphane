using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;
namespace Kutuphane.BLL.Abstract
{
    public interface IKitapService : IBLLVeriCekme<Kitap>, IBLLVeriGuncelleme<Kitap>, IBLLVeriOlusturma<Kitap>
    {
        IDataResult<List<KitapDto>> KitapListeDetayliGetirServis(Expression<Func<Kitap, bool>>? predicate = null);
        IDataResult<List<OduncKitapDto>> OduncIcinListeGetir(Expression<Func<Kitap, bool>>? predicate = null);
    }
}
