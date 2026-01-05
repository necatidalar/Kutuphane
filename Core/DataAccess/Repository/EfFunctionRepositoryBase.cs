using Core.Entity;
using Core.Interfaces;
using Core.Utility.Results;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Repository
{

    public class EfFunctionRepositoryBase<TContext> : IFunctionRepository

        where TContext : DbContext, new()
    {
        public IDataResult<T> ExecuteScalarFunction<T>(string functionName, params object[] parameters)
        {
            try
            {
                using var db = new TContext();
                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                var sql = $"SELECT dbo.{functionName}({FormatSqlParameters(parameters.Length)})";
                var connection = db.Database.GetDbConnection();

                using var command = connection.CreateCommand();
                command.CommandText = sql;

                for (int i = 0; i < parameters.Length; i++)
                {
                    var parameter = command.CreateParameter();
                    parameter.ParameterName = $"@p{i}";
                    parameter.Value = parameters[i] ?? DBNull.Value;
                    command.Parameters.Add(parameter);
                }

                connection.Open();
                var result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return new SuccessDataResult<T>(default(T));
                }

                return new SuccessDataResult<T>((T)Convert.ChangeType(result, typeof(T)));
            }
            catch (Exception e)
            {
                return new ErrorDataResult<T>(e.Message);
            }
        }

        public IDataResult<List<T>> ExecuteTableFunction<T>(string functionName, params object[] parameters) where T : class, IDto, new()
        {
            try
            {
                using var db = new TContext();
                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                var sql = $"SELECT * FROM dbo.{functionName}({FormatSqlParameters(parameters.Length)})";
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
