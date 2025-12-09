using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IDilDal : IDalVeriCekme<Dil>, IDalVeriOlusturma<Dil>, IDalVeriGunceleme<Dil>
    {
        IDataResult<List<Dil>> DilListeDetayliGetir(Expression<Func<Dil, bool>>? predicate = null);
    }
}
