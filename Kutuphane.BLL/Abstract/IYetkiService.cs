using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Abstract
{
    public interface IYetkiService : IBLLVeriCekme<Yetki>, IBLLVeriGuncelleme<Yetki>, IBLLVeriOlusturma<Yetki>
    {
    }
}