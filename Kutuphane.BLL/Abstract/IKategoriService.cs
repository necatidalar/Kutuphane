using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Abstract
{
    public interface IKategoriService : IBLLVeriCekme<Kategori>, IBLLVeriGuncelleme<Kategori>, IBLLVeriOlusturma<Kategori>
    {
    }
}
