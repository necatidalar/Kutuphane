using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IUyeDal : IDalVeriCekme<Uye>, IDalVeriOlusturma<Uye>, IDalVeriGunceleme<Uye>
    {
        IDataResult<List<UyeDto>> UyeListeDetayliGetir(Expression<Func<Uye, bool>>? predicate = null);
    }

}
