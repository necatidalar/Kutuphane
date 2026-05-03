using Core.Entity;
using Core.Utility.Results;
using Kutuphane.BLL.Abstract;
using Kutuphane.DAL.Abstract;
using Kutuphane.Model.DTO;
using System.Data;

namespace Kutuphane.BLL.Concrete
{
    public class V2DashboardMenuManager : IV2DashboardMenuService
    {
        private readonly IStoredProcedureDal _storedProcedureDal;

        public V2DashboardMenuManager(IStoredProcedureDal storedProcedureDal)
        {
            _storedProcedureDal = storedProcedureDal;
        }

        public IDataResult<List<DashboardWidgetDto>> DashboardWidgetlariniGetir(int kurumId, int? rolId = null)
        {
            if (kurumId <= 0)
                return new ErrorDataResult<List<DashboardWidgetDto>>("KurumId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<DashboardWidgetDto>(
                "sp_DashboardWidgetlariniGetir",
                kurumId,
                rolId.HasValue ? rolId.Value : (object)DBNull.Value);
        }

        public IDataResult<List<DashboardWidgetDto>> DashboardWidgetAyarlariniGetir(int kurumId)
        {
            if (kurumId <= 0)
                return new ErrorDataResult<List<DashboardWidgetDto>>("KurumId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<DashboardWidgetDto>(
                "sp_DashboardWidgetAyarlariniGetir",
                kurumId);
        }

        public IResult DashboardWidgetAyariKaydet(int kurumId, int dashboardWidgetId, bool gorunurMu, int siraNo, int? kullaniciId = null)
        {
            if (kurumId <= 0)
                return new ErrorResult("KurumId geçersiz.");

            if (dashboardWidgetId <= 0)
                return new ErrorResult("Dashboard widget seçimi geçersiz.");

            if (siraNo <= 0)
                return new ErrorResult("Sıra numarası 1 veya daha büyük olmalıdır.");

            return _storedProcedureDal.ExecuteStoredProcedureNoReturn(
                "sp_DashboardWidgetAyariKaydet",
                kurumId,
                dashboardWidgetId,
                gorunurMu,
                siraNo,
                kullaniciId.HasValue ? kullaniciId.Value : (object)DBNull.Value);
        }


        public IDataResult<List<DashboardOzetDto>> DashboardOzetGetir()
        {
            return _storedProcedureDal.ExecuteStoredProcedure<DashboardOzetDto>(
                "sp_DashboardOzetGetir");
        }

        public IDataResult<List<T>> DashboardWidgetVerisiGetir<T>(string veriKaynagi)
            where T : class, IDto, new()
        {
            if (string.IsNullOrWhiteSpace(veriKaynagi))
                return new ErrorDataResult<List<T>>("Veri kaynağı boş olamaz.");

            return _storedProcedureDal.ExecuteStoredProcedure<T>(
                "sp_DashboardWidgetVerisiGetir",
                veriKaynagi);
        }

        public IDataResult<DataTable> DashboardWidgetVerisiGetir(string veriKaynagi)
        {
            if (string.IsNullOrWhiteSpace(veriKaynagi))
                return new ErrorDataResult<DataTable>("Veri kaynağı boş olamaz.");

            return _storedProcedureDal.ExecuteStoredProcedureDataTable(
                "sp_DashboardWidgetVerisiGetir",
                veriKaynagi);
        }

        public IDataResult<List<MenuTanimDto>> MenuTanimlariniGetir(int kurumId, int? rolId = null)
        {
            if (kurumId <= 0)
                return new ErrorDataResult<List<MenuTanimDto>>("KurumId geçersiz.");

            return _storedProcedureDal.ExecuteStoredProcedure<MenuTanimDto>(
                "sp_MenuTanimlariniGetir",
                kurumId,
                rolId.HasValue ? rolId.Value : (object)DBNull.Value);
        }
    }
}
