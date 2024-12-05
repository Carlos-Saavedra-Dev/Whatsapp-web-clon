using ChatApp.Application.Interfaces;
using ChatApp.Core.Interfaces;
using ChatApp.Core.Services;
using ChatApp.Infraestructure.Data;
using ChatApp.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ChatApp.Infraestructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ChatAppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //Services
            services.AddScoped<IUserService, UserService>();
            //Repository
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
