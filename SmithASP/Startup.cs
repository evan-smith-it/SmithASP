using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmithASP.Models;

namespace SmithASP
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddApplicationInsightsSettings(developerMode: true);
            }
            Configuration = builder.Build();
        }
        public IConfigurationRoot Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetry(Configuration);
            services.AddMvc();
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ProfileContext>().AddDefaultTokenProviders();
            services.AddDbContext<Models.CryptogramDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddDbContext<Models.DbContexts.WorkoutContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:WorkoutConnection"]));
            services.AddDbContext<Models.ProfileContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:ProfileConnection"]));
            services.AddDbContext<Models.DbContexts.CircuitContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:CircuitConnection"]));
            //Configuration["ConnectionStrings:DefaultConnection"] vs Configuration.GetConnectionString("DefaultConnection")
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                //tells the program how to handle exceptions
                app.UseExceptionHandler("/Main/Error");
            }
            //Used to read static files from wwwroot
            app.UseStaticFiles();

            app.UseMvc();

            app.UseAuthentication();

            //Routes the http requests using the mvc structure
            app.UseMvc(routes =>
            {
                routes.MapRoute(

                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Crypto", action = "index" }
                );
            });
        }
    }
}
