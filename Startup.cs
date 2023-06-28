using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BTL
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

            services.AddAuthentication("BTL_ASPSecurityScheme").AddCookie("BTL_ASPSecurityScheme", options =>
            {
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = "BTL_ASP.Security.Cookie",
                    Path = "/",
                    SameSite = SameSiteMode.Lax,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest
                };
                options.LoginPath = "/Admin/Accounts/Login";
                options.ReturnUrlParameter = "UrlRedirect";
                options.SlidingExpiration = true;
            });

            services.AddDistributedMemoryCache();
            services.AddSession(ops =>
            {
                ops.IdleTimeout = TimeSpan.FromHours(1);
                ops.Cookie.Name = ".MetronicShop.Session";
                ops.Cookie.HttpOnly = true;
            });

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc();
            services.AddDbContext<BTL_ASPNetCoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BTL_ASPNetCoreString")));
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
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "admin",
                    template: "{area:exists}/{controller=Accounts}/{action=Login}/{id?}");
            });
        }
    }
}
