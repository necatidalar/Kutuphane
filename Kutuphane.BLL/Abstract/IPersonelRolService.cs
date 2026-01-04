using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Abstract
{
    public interface IPersonelRolService : IBLLVeriCekme<PersonelRol>, IBLLVeriGuncelleme<PersonelRol>, IBLLVeriOlusturma<PersonelRol>, IBLLVeriSilme<PersonelRol>
    {
        IDataResult<List<PersonelRolDto>> PersonelRolleriniGetir(Expression<Func<PersonelRol, bool>>? predicate = null);
    }
}
