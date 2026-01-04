using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IOduncService : IBLLVeriCekme<Odunc>, IBLLVeriGuncelleme<Odunc>, IBLLVeriOlusturma<Odunc>
    {
        IDataResult<List<OduncBilgileriDto>> OduncBilgileriGetirServis(Expression<Func<Odunc, bool>>? predicate = null);
    }
}