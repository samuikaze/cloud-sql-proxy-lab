using CloudSQLAuthProxy.Lab.Api.Models.ServiceModels;

namespace CloudSQLAuthProxy.Lab.Api.Services
{
    public interface IUserService
    {
        /// <summary>
        /// 取得所有使用者資料
        /// </summary>
        /// <returns></returns>
        public abstract Task<List<UserServiceModel>> GetUsers();
    }
}
