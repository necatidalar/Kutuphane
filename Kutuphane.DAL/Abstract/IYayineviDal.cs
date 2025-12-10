using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IYayineviDal : IDalVeriCekme<Yayinevi>, IDalVeriOlusturma<Yayinevi>, IDalVeriGunceleme<Yayinevi>
    {
    }
}
