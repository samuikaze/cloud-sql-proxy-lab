namespace CloudSQLAuthProxy.Lab.Api.Models.ServiceModels
{
    public class UserServiceModel
    {
        /// <summary>
        /// 使用者 PK
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 使用者名稱
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 暱稱
        /// </summary>
        public string? Nickname { get; set; } = null!;

        /// <summary>
        /// 性別
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 電子郵件地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 最後更新時間
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}
