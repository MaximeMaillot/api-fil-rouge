using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFHelper.Interfaces
{
    public interface IRepository<TEntity>
    {
        // ------ SYNCHRONOUS ------ //
        // CREATE
        int Add(TEntity entity);
        // READ
        TEntity? Find(params object[] id);
        TEntity? Find(int id);
        TEntity? Get();
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        TEntity? Get(params Expression<Func<TEntity, object>>[] includes);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        // UPDATE
        bool Update(TEntity entity);
        // DELETE
        bool Remove(params object[] id);
        bool Remove(int id);
        bool Remove(TEntity entity);

        // ------ ASYNCHRONOUS ------ //
        // CREATE ASYNC
        Task<int> AddAsync(TEntity entity);
        // READ ASYNC
        Task<TEntity?> FindAsync(params object[] id);
        Task<TEntity?> FindAsync(int id);
        Task<TEntity?> GetAsync();
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity?> GetAsync(params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        // UPDATE ASYNC
        Task<bool> UpdateAsync(TEntity entity);
    }
}
