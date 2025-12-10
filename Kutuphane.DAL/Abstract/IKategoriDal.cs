using Core.Interfaces;
using Core.Utility.Results;
using Kutuphane.Model.Entity;
using System.Linq.Expressions;

namespace Kutuphane.DAL.Abstract
{
    public interface IKategoriDal : IDalVeriCekme<Kategori>, IDalVeriOlusturma<Kategori>, IDalVeriGunceleme<Kategori>
    {
    }
}
