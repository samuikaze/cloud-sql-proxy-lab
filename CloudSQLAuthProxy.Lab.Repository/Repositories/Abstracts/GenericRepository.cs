using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CloudSQLAuthProxy.Lab.Repository.Repositories.Abstracts
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 取得符合條件的第一筆資料
        /// </summary>
        /// <param name="predicate">條件 Lambda</param>
        /// <returns></returns>
        public virtual async Task<TEntity?> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().AsQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// 取得符合條件的所有資料
        /// </summary>
        /// <param name="predicate">條件 Lambda</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().AsQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<TEntity>> GetAsync()
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().AsQueryable();

            return await query
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// 插入一筆新資料
        /// </summary>
        /// <param name="entity">新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<int> CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity cannot be null.");
            }

            _context.Set<TEntity>().Add(entity);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 插入多筆新資料
        /// </summary>
        /// <param name="entities">多筆新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<int> CreateAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entity cannot be null.");
            }

            _context.Set<TEntity>().AddRange(entities);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 更新單筆資料
        /// </summary>
        /// <param name="entity">更新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<int> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity cannot be null.");
            }

            _context.Set<TEntity>().Update(entity);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 更新多筆資料
        /// </summary>
        /// <param name="entities">多筆更新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<int> UpdateAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entity cannot be null.");
            }

            _context.Set<TEntity>().UpdateRange(entities);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 刪除單筆資料
        /// </summary>
        /// <param name="entity">單筆欲刪除的資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<int> DeleteAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity cannot be null.");
            }

            _context.Set<TEntity>().Remove(entity);

            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 刪除多筆資料
        /// </summary>
        /// <param name="entities">多筆欲刪除的資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<int> DeleteAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entity cannot be null.");
            }

            _context.Set<TEntity>().RemoveRange(entities);

            return await _context.SaveChangesAsync();
        }
    }
}
