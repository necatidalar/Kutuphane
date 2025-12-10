

namespace Kutuphane.DAL.Contexes
{
    public enum DbContextType
    {
        Supervisor,
        StajPc,
        Home
    }

    public static class DbContextSelector
    {
        private static DbContextType _currentContext = DbContextType.Supervisor;

        public static DbContextType CurrentContext
        {
            get => _currentContext;
            set => _currentContext = value;
        }

        public static Type GetContextType()
        {
            return _currentContext switch
            {
                DbContextType.Supervisor => typeof(SupervisorDbContext),
                DbContextType.StajPc => typeof(KutuphaneDbContext),
                DbContextType.Home => typeof(HomeDbContext),
                _ => typeof(KutuphaneDbContext)
            };
        }
    }
}
