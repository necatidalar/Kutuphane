using Core.Entity;
using Core.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Core.Utility.Results;

namespace Core.DataAccess.Repository
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>  
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {


        public IDataResult<List<TEntity>> GetListByFilter(Expression<Func<TEntity, bool>>? predicate = null)
        {
            try
            {
                using var db = new TContext();
                var query = db.Set<TEntity>().AsQueryable();
                if (predicate != null) query = query.Where(predicate);
                return new SuccessDataResult<List<TEntity>>(query.ToList());
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<TEntity>>(e.Message);
            }
            
        }

        public IDataResult<TEntity?> GetByFilter(Expression<Func<TEntity, bool>>? predicate = null)
        {
            try
            {
                using var db = new TContext();
                var query = db.Set<TEntity>().AsQueryable();
                if (predicate != null) query = query.Where(predicate);
                return new SuccessDataResult<TEntity?>(db.Set<TEntity>().FirstOrDefault(predicate));
            }
            catch (Exception e )
            {

                return new ErrorDataResult<TEntity?>(e.Message);
            }
            
        }

        public IResult Add(TEntity entity)
        {
            try
            {
                using var db = new TContext();
                db.Set<TEntity>().Add(entity);
                db.SaveChanges();
                return new SuccessResult();
            }
            catch (Exception e)
            {

               return new ErrorResult(e.Message);
            }
            
        }

        public IResult Update(TEntity entity)
        {
            try
            {
                using var db = new TContext();
                db.Set<TEntity>().Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                return new SuccessResult();
            }
            catch (Exception e )
            {
                return new ErrorResult(e.Message);
            }
            
        }

        public IResult Delete(TEntity entity)
        {
            try
            {
                using var db = new TContext();
                db.Set<TEntity>().Remove(entity);
                db.SaveChanges();
                return new SuccessResult();
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
            
        }
    }
}