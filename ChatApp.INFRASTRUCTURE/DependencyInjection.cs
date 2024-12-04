using ChatApp.Application.Interfaces;
using ChatApp.Core.Interfaces;
using ChatApp.Core.Services;
using ChatApp.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ChatApp.Infraestructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        { 
        
            //Services
            services.AddScoped<IUserService, UserService>();
            //Repository
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
