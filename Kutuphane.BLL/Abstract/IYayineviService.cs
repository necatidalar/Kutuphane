using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Abstract
{
    public interface IYayineviService : IBLLVeriCekme<Yayinevi>, IBLLVeriGuncelleme<Yayinevi>, IBLLVeriOlusturma<Yayinevi>
    {
    }
}
