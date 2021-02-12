using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace mongoFlix.API.Configurations
{
    public static class APIConfiguration
    {
        public static IServiceCollection AddAPIConfiguration(this IServiceCollection services)
        {
            services.AddControllers();

            return services;
        }

        public static IApplicationBuilder UseRazorConfig(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            return app;
        }
    }
}