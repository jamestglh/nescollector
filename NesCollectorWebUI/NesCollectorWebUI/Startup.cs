using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NesCollector.Data.Context;
using NesCollector.Data.Implementation.EFCore;
using NesCollector.Data.Implementation.Mock;
using NesCollector.Data.Interfaces;
using NesCollector.Models;
using NesCollector.Service.Services;

namespace NesCollectorWebUI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //repository layer  injection
            //GetDependancyResolvedForMockRepositoryLayer(services);
            GetDependancyResolvedForEFCoreRepositoryLayer(services);


            //services layer injection
            GetDependancyResolvedForServiceLayer(services);

            services.AddDbContext<NesCollectorDBContext>();
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<NesCollectorDBContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }

        private void GetDependancyResolvedForMockRepositoryLayer(IServiceCollection services)
        {
            services.AddScoped<IGameRepository, MockGameRepository>();
            services.AddScoped<IUserGameRepository, MockUserGameRepository>();
            services.AddScoped<IAppUserRepository, MockAppUserRepository>();
            services.AddScoped<IWishlistRepository, MockWishlistRepository>();
            services.AddScoped<IGameConsoleRepository, MockGameConsoleRepository>();
        }

        private void GetDependancyResolvedForEFCoreRepositoryLayer(IServiceCollection services)
        {
            services.AddScoped<IGameRepository, EFCoreGameRepository>();
            services.AddScoped<IUserGameRepository, EFCoreUserGameRepository>();
            services.AddScoped<IAppUserRepository, EFCoreAppUserRepository>();
            services.AddScoped<IWishlistRepository, EFCoreWishlistRepository>();
            services.AddScoped<IGameConsoleRepository, EFCoreGameConsoleRepository>();
        }

        private void GetDependancyResolvedForServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IUserGameService, UserGameService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWishlistService, WishlistService>();
            services.AddScoped<IGameConsoleService, GameConsoleService>();
        }
    }
}
