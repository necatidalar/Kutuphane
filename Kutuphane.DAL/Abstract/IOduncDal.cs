using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IOduncDal : IDalVeriCekme<Odunc>, IDalVeriOlusturma<Odunc>, IDalVeriGunceleme<Odunc>
    {
        IDataResult<List<OduncBilgileriDto>> OduncBilgileriGetir(Expression<Func<Odunc, bool>>? predicate = null);
    }
}