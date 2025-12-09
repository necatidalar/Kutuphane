using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface ICinsiyetService : IBLLVeriCekme<Cinsiyet>, IBLLVeriGuncelleme<Cinsiyet>, IBLLVeriOlusturma<Cinsiyet>
    {
    }
}
