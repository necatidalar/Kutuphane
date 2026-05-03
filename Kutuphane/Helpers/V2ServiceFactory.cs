using Kutuphane.BLL.Abstract;
using Kutuphane.BLL.Concrete;
using Kutuphane.DAL.Concrete.EntityFramework;

namespace Kutuphane.UI.Helpers
{
    public static class V2ServiceFactory
    {
        public static IV2DinamikAlanService DinamikAlanService()
        {
            return new V2DinamikAlanManager(new EfStoredProcedureDal());
        }

        public static IV2DashboardMenuService DashboardMenuService()
        {
            return new V2DashboardMenuManager(new EfStoredProcedureDal());
        }

        public static IV2SistemService SistemService()
        {
            return new V2SistemManager(new EfStoredProcedureDal());
        }

        public static IV2OduncIslemService OduncIslemService()
        {
            return new V2OduncIslemManager(new EfStoredProcedureDal());
        }
    }
}
