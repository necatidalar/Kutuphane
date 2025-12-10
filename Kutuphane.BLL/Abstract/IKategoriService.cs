using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IKategoriService : IBLLVeriCekme<Kategori>, IBLLVeriGuncelleme<Kategori>, IBLLVeriOlusturma<Kategori>
    {
    }
}
