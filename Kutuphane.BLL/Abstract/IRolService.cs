using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Abstract
{
    public interface IRolService : IBLLVeriCekme<Rol>, IBLLVeriGuncelleme<Rol>, IBLLVeriOlusturma<Rol>
    {
    }
}