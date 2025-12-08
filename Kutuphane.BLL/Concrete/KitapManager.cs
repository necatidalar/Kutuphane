using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.BLL.Concrete
{
    public class KitapManager : IKitapService
    {
        readonly IKitapDal _kitapDal;

        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }

        public IResult AddService(Kitap entity)
        {
            //return new ErrorResult("hatavar baba");
            return _kitapDal.Add(entity);
        }

        public IDataResult<Kitap> GetByFilterService(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return _kitapDal.GetByFilter(predicate);
        }

        public IDataResult<List<Kitap>> GetListByFilterService(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return _kitapDal.GetListByFilter(predicate);
        }

        public IResult UpdateService(Kitap entity)
        {
            return _kitapDal.Update(entity);
        }
        public IDataResult<List<KitapDto>> KitapListeDetayliGetirServis(Expression<Func<Kitap, bool>>? predicate = null)
        {
            return _kitapDal.KitapListeDetayliGetir(predicate);
        }
    }
}
