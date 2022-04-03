using KEM.EventManager.Application.Services;
using KEM.EventManager.Domaine.Repositories;
using KEM.EventManager.Infrastructure.Repositories;

namespace KEM.EventManager.API.Extensions
{
    public static class DIExtension
    {
        public static IServiceCollection EventManagerServices(this IServiceCollection services)
        {
            
            services.AddScoped<IManagedEventService, ManagedEventService>();
            services.AddScoped<IManagedEventRepository, ManagedEventRepository>();

            return services;
        }
    }
}
