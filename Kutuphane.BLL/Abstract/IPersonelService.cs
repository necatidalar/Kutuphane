using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IPersonelService : IBLLVeriCekme<Personel>, IBLLVeriGuncelleme<Personel>, IBLLVeriOlusturma<Personel>
    {
        IDataResult<List<PersonelBilgileriDto>> PersonelBilgiGetirServis(Expression<Func<Personel, bool>>? predicate = null);

        IDataResult<List<PersonelOduncBilgileriDto>> PersonelOduncListeIleGetirServis(Expression<Func<Personel, bool>>? predicate = null);
    }
}
