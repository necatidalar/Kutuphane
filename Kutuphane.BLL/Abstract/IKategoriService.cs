using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IKategoriService : IBLLVeriCekme<Kategori>, IBLLVeriGuncelleme<Kategori>, IBLLVeriOlusturma<Kategori>
    {
        IDataResult<List<Kategori>> KategoriListeDetayliGetirServis(Expression<Func<Kategori, bool>>? predicate = null);
    }
}
