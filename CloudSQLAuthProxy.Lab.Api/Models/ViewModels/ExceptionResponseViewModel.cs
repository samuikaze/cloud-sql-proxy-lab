namespace CloudSQLAuthProxy.Lab.Api.Models.ViewModels
{
    public class ExceptionResponseViewModel
    {
        /// <summary>
        /// 錯誤狀態碼
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 錯誤名稱
        /// </summary>
        public string? Errors { get; set; }
        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string? Message { get; set; }
    }
}
