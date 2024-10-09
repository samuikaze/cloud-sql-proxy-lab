using System.Linq.Expressions;

namespace CloudSQLAuthProxy.Lab.Repository.Repositories.Abstracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// 取得符合條件的第一筆資料
        /// </summary>
        /// <param name="predicate">條件 Lambda</param>
        /// <returns></returns>
        public Task<TEntity?> FirstAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 取得符合條件的所有資料
        /// </summary>
        /// <param name="predicate">條件 Lambda</param>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> GetAsync();

        /// <summary>
        /// 插入一筆新資料
        /// </summary>
        /// <param name="entity">新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task<int> CreateAsync(TEntity entity);

        /// <summary>
        /// 插入多筆新資料
        /// </summary>
        /// <param name="entities">多筆新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task<int> CreateAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 更新單筆資料
        /// </summary>
        /// <param name="entity">更新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task<int> UpdateAsync(TEntity entity);

        /// <summary>
        /// 更新多筆資料
        /// </summary>
        /// <param name="entities">多筆更新資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task<int> UpdateAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 刪除單筆資料
        /// </summary>
        /// <param name="entity">單筆欲刪除的資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task<int> DeleteAsync(TEntity entity);

        /// <summary>
        /// 刪除多筆資料
        /// </summary>
        /// <param name="entities">多筆欲刪除的資料</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task<int> DeleteAsync(IEnumerable<TEntity> entities);
    }
}
