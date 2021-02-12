using Microsoft.Extensions.DependencyInjection;
using mongoFlix.API.Domain.Repositories;
using mongoFlix.API.Domain.Services;
using mongoFlix.API.Infra.Data.Context;
using mongoFlix.API.Infra.Data.Repositories;

namespace mongoFlix.API.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            //services.AddScoped<INotificator, Notificator>();
            services.AddScoped<MongoFlixDbContext>();

            RegisterRepositoriesDependencies(services);
            RegisterServiceDependencies(services);

            return services;
        }

        private static void RegisterRepositoriesDependencies(IServiceCollection services)
        {
            services.AddTransient<IMovieRepository, MovieRepository>();
        }
        private static void RegisterServiceDependencies(IServiceCollection services)
        {
            services.AddTransient<IMovieService, MovieService>();
        }
    }
}