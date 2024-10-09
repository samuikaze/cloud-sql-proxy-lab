namespace CloudSQLAuthProxy.Lab.Api.Extensions
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder ConfigureMiddlewares(this IApplicationBuilder builder)
        {
           return builder;
        }
    }
}
