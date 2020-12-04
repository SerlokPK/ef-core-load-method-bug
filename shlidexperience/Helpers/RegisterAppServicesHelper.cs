using Interfaces.Repositories;
using Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Repositories.UserRepo;
using Services.UserSer;

namespace shlidexperience.helpers
{
    public static class RegisterAppServicesHelper
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection RegisterAppRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
