using Core.Entity;
using Core.Interfaces;
using Core.Utility.Results;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Repository
{
    public class EfStoredProcedureRepositoryBase<TContext> : IStoredProcedureRepository
        where TContext : DbContext, new()
    {

        public IResult ExecuteStoredProcedureNoReturn(string spName, params object[] parameters)
        {
            try
            {
                using var db = new TContext();
                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                var sql = $"EXEC dbo.{spName} {FormatSqlParameters(parameters.Length)}";
                return new SuccessResult(db.Database.ExecuteSqlRawAsync(sql, parameters).ToString());
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<T>> ExecuteStoredProcedure<T>(string spName, params object[] parameters) where T : class, IDto, new()
        {
            try
            {
                using var db = new TContext();
                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                var sql = $"EXEC dbo.{spName} {FormatSqlParameters(parameters.Length)}";
                return new SuccessDataResult<List<T>>(db.Set<T>().FromSqlRaw(sql, parameters).ToList());
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<T>>(e.Message);
            }
        }

        private string FormatSqlParameters(int count)
        {
            return string.Join(",", Enumerable.Range(0, count).Select(i => $"@p{i}"));
        }
    }
}
