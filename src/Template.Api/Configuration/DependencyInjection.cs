using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Template.Business.Interfaces;
using Template.Business.Notifications;
using Template.Business.Servicecs;
using Template.Data.Context;
using Template.Data.Repository;
using Template.Identity.Exensions;

namespace Template.Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IExampleRepository, ExampleRepository>();
            services.AddScoped<IExampleService, ExampleService>();
            


            services.AddScoped<INotificator, Notificator>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            return services;
        }
    }
}
