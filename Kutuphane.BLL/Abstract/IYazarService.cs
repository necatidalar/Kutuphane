using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IYazarService : IBLLVeriCekme<Yazar>, IBLLVeriGuncelleme<Yazar>, IBLLVeriOlusturma<Yazar>
    {
        IDataResult<List<YazarDto>> YazarListeGetirServis(Expression<Func<Yazar, bool>>? predicate = null);

    }
}
