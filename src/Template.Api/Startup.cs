using Asp.Versioning.ApiExplorer;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Template.Api.Configuration;
using Template.Data.Context;

namespace Template.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddIdentityConfiguration(Configuration);
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.WebApiConfig();
            services.AddSwaggerConfig();

            services.ResolveDependencies();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            // Configure the HTTP request pipeline.

            app.UseRouting();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwaggerConfig(provider);
            app.UseMvcConfiguration();
        }
    }
}
