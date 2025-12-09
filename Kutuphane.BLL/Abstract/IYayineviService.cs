using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IYayineviService : IBLLVeriCekme<Yayinevi>, IBLLVeriGuncelleme<Yayinevi>, IBLLVeriOlusturma<Yayinevi>
    {
        IDataResult<List<Yayinevi>> YayineviListeDetayliGetirServis(Expression<Func<Yayinevi, bool>>? predicate = null);

    }
}
