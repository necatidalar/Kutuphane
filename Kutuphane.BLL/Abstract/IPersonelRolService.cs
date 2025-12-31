using Core.Interfaces;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL.Abstract
{
    public interface IPersonelRolService : IBLLVeriCekme<PersonelRol>, IBLLVeriGuncelleme<PersonelRol>, IBLLVeriOlusturma<PersonelRol>
    {
    }
}
