using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Abstract
{
    public interface IDilService : IBLLVeriCekme<Dil>, IBLLVeriGuncelleme<Dil>, IBLLVeriOlusturma<Dil>
    {
    }
}
