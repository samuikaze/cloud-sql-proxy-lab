namespace CloudSQLAuthProxy.Lab.Api.Extensions
{
    public static class CorsHandlerExtension
    {
        public static string CorsPolicyName = "GlobalCORSPolicy";

        public static IServiceCollection ConfigureCorsHeaders(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddCors(options =>
            {
                options.AddPolicy(
                    name: CorsPolicyName,
                    policy =>
                    {
                        policy.WithOrigins("*")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            return serviceCollection;
        }
    }
}
