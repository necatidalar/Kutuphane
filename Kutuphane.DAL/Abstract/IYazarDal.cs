using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IYazarDal : IDalVeriCekme<Yazar>, IDalVeriOlusturma<Yazar>, IDalVeriGunceleme<Yazar>
    {
        IDataResult<List<YazarDto>> YazarListeGetir(Expression<Func<Yazar, bool>>? predicate = null);
    }
}
