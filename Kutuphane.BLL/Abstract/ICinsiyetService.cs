using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Abstract
{
    public interface ICinsiyetService : IBLLVeriCekme<Cinsiyet>, IBLLVeriGuncelleme<Cinsiyet>, IBLLVeriOlusturma<Cinsiyet>
    {
    }
}
