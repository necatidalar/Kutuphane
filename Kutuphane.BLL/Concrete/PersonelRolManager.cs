using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.DAL.Concrete;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

public class PersonelRolManager : IPersonelRolService
{
    readonly IPersonelRolDal _dal;

    public PersonelRolManager(IPersonelRolDal dal)
    {
        _dal = dal;
    }

    private IResult Validate(PersonelRol entity)
    {
        if (entity.PersonelId <= 0)
            return new ErrorResult("Geçersiz Personel.");

        if (entity.RolId <= 0)
            return new ErrorResult("Geçersiz Rol.");

        var varMi = _dal.GetByFilter(x =>
            x.PersonelId == entity.PersonelId &&
            x.RolId == entity.RolId
        ).Data;

        if (varMi != null)
            return new ErrorResult("Bu personelde bu rol zaten mevcut.");

        return new SuccessResult();
    }
    public IResult AddService(PersonelRol entity)
    {
        var v = Validate(entity);
        if (!v.IsSuccess) return v;

        _dal.Add(entity);
        return new SuccessResult("Personel rolü eklendi.");
    }
    public IResult UpdateService(PersonelRol entity)
    {
        _dal.Update(entity);
        return new SuccessResult("Personel rolü güncellendi.");
    }
    public IResult DeleteService(PersonelRol entity)
    {
        if (entity == null)
            return new ErrorResult("Silinecek kayıt boş olamaz.");

        if (entity.PersonelRolId <= 0)
            return new ErrorResult("Geçersiz PersonelRolId.");

        var dbKayit = _dal.GetByFilter(x => x.PersonelRolId == entity.PersonelRolId).Data;

        if (dbKayit == null)
            return new ErrorResult("Personel rol kaydı bulunamadı.");

        _dal.Delete(dbKayit);
        return new SuccessResult("Personelin rolü kaldırıldı.");
    }
    public IDataResult<PersonelRol> GetByFilterService(Expression<Func<PersonelRol, bool>>? predicate = null)
    {
        return _dal.GetByFilter(predicate);
    }
    public IDataResult<List<PersonelRol>> GetListByFilterService(Expression<Func<PersonelRol, bool>>? predicate = null)
    {
        return _dal.GetListByFilter(predicate);
    }
    public IDataResult<List<PersonelRolDto>> PersonelRolleriniGetir(Expression<Func<PersonelRol, bool>>? predicate = null)
    {
        return _dal.PersonelRolleriniGetir(predicate);
    }
}