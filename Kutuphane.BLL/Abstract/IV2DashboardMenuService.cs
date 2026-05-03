using Core.Entity;
using Core.Utility.Results;
using Kutuphane.Model.DTO;
using System.Data;

namespace Kutuphane.BLL.Abstract
{
    public interface IV2DashboardMenuService
    {
        IDataResult<List<DashboardWidgetDto>> DashboardWidgetlariniGetir(int kurumId, int? rolId = null);

        IDataResult<List<DashboardWidgetDto>> DashboardWidgetAyarlariniGetir(int kurumId);

        IResult DashboardWidgetAyariKaydet(int kurumId, int dashboardWidgetId, bool gorunurMu, int siraNo, int? kullaniciId = null);

        IDataResult<List<DashboardOzetDto>> DashboardOzetGetir();

        IDataResult<List<T>> DashboardWidgetVerisiGetir<T>(string veriKaynagi) where T : class, IDto, new();

        IDataResult<DataTable> DashboardWidgetVerisiGetir(string veriKaynagi);

        IDataResult<List<MenuTanimDto>> MenuTanimlariniGetir(int kurumId, int? rolId = null);
    }
}
