using Eterna.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<EternaDbContext>(opt =>
            {
                opt.UseSqlServer("Server=DESKTOP-HO9CBPN\\SQLEXPRESS;Database=EternaDb; Trusted_Connection=TRUE");
            }
                );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name:"about",
                    pattern: "about",
                    defaults: new { controller = "Home", action = "About" }
                    );
                endpoints.MapControllerRoute(
                    name: "services",
                    pattern: "services",
                    defaults: new { controller = "Service", action = "Index" }
                    );
            });
        }
    }
}
