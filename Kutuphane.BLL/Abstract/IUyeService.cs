using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IUyeService : IBLLVeriCekme<Uye>, IBLLVeriGuncelleme<Uye>, IBLLVeriOlusturma<Uye>
    {
        IDataResult<List<UyeDto>> UyeListeDetayliGetirServis(Expression<Func<Uye, bool>>? predicate = null);
    }
}
