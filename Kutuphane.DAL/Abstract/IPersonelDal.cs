using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IPersonelDal : IDalVeriCekme<Personel>, IDalVeriOlusturma<Personel>, IDalVeriGunceleme<Personel>
    {
        IDataResult<List<Personel>> PersonelListeDetayliGetir(Expression<Func<Personel, bool>>? predicate = null);

    }
}
