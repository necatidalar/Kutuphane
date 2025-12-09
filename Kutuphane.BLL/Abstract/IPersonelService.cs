using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IPersonelService : IBLLVeriCekme<Personel>, IBLLVeriGuncelleme<Personel>, IBLLVeriOlusturma<Personel>
    {
        IDataResult<List<Personel>> PersonelListeDetayliGetirServis(Expression<Func<Personel, bool>>? predicate = null);
    }
}
