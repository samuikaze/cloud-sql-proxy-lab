using CloudSQLAuthProxy.Lab.Api.Services;
using CloudSQLAuthProxy.Lab.Repository.Repositories.Carousel;

namespace CloudSQLAuthProxy.Lab.Api.Extensions
{
    public class ServiceMapperExtension
    {
        public static IServiceCollection? GetServiceProvider(IServiceCollection? serviceCollection)
        {
            if (serviceCollection != null)
            {
                // Services
                serviceCollection.AddScoped<IUserService, UserService>();

                // Repositories
                serviceCollection.AddScoped<IUserRepository, UserRepository>();
            }

            return serviceCollection;
        }
    }
}
