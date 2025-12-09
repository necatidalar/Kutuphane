using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IYazarService : IBLLVeriCekme<Yazar>, IBLLVeriGuncelleme<Yazar>, IBLLVeriOlusturma<Yazar>
    {
        IDataResult<List<Yazar>> YazarListeDetayliGetirServis(Expression<Func<Yazar, bool>>? predicate = null);

    }
}
