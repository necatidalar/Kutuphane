using Core.Entity;
using Core.Interfaces;
using Core.Utility.Results;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

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

                var sqlParameters = BuildSqlParameters(parameters);
                var sql = BuildExecSql(spName, sqlParameters.Length);

                var affectedRows = db.Database.ExecuteSqlRaw(sql, sqlParameters);

                return new SuccessResult($"{affectedRows} kayıt etkilendi.");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<T>> ExecuteStoredProcedure<T>(string spName, params object[] parameters)
            where T : class, IDto, new()
        {
            try
            {
                using var db = new TContext();

                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                var sqlParameters = BuildSqlParameters(parameters);
                var sql = BuildExecSql(spName, sqlParameters.Length);

                var result = db.Database
                    .SqlQueryRaw<T>(sql, sqlParameters)
                    .ToList();

                return new SuccessDataResult<List<T>>(result);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<T>>(e.Message);
            }
        }


        public IDataResult<DataTable> ExecuteStoredProcedureDataTable(string spName, params object[] parameters)
        {
            try
            {
                using var db = new TContext();

                db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                var sqlParameters = BuildSqlParameters(parameters);

                using var command = db.Database.GetDbConnection().CreateCommand();
                command.CommandText = BuildExecSql(spName, sqlParameters.Length);
                command.CommandType = CommandType.Text;

                foreach (var parameter in sqlParameters)
                {
                    command.Parameters.Add(parameter);
                }

                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                using var reader = command.ExecuteReader();
                var table = new DataTable();
                table.Load(reader);

                return new SuccessDataResult<DataTable>(table);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<DataTable>(e.Message);
            }
        }

        private static SqlParameter[] BuildSqlParameters(object[] parameters)
        {
            if (parameters == null || parameters.Length == 0)
                return Array.Empty<SqlParameter>();

            var sqlParameters = new SqlParameter[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                var value = parameters[i];

                var parameter = new SqlParameter($"@p{i}", value ?? DBNull.Value);

                if (value == null || value == DBNull.Value)
                {
                    parameter.Value = DBNull.Value;
                    parameter.IsNullable = true;
                }

                sqlParameters[i] = parameter;
            }

            return sqlParameters;
        }

        private static string BuildExecSql(string spName, int parameterCount)
        {
            if (string.IsNullOrWhiteSpace(spName))
                throw new ArgumentException("Stored procedure adı boş olamaz.", nameof(spName));

            if (parameterCount <= 0)
                return $"EXEC dbo.{spName}";

            var parameterText = string.Join(
                ", ",
                Enumerable.Range(0, parameterCount).Select(i => $"@p{i}")
            );

            return $"EXEC dbo.{spName} {parameterText}";
        }
    }
}