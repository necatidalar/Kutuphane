using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IDilService : IBLLVeriCekme<Dil>, IBLLVeriGuncelleme<Dil>, IBLLVeriOlusturma<Dil>
    {
    }
}
