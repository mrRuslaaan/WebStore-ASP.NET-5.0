using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using WebStore.Infrastructure.Interfaces;
using WebStore.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using WebStore.DAL.Context;
using WebStore.Data;
using WebStore.Infrastructure.Services.InMemory;
using WebStore.Infrastructure.Services.InSql;

namespace WebStore
{
    public class Startup
    {
        private readonly IConfiguration _Configuration;
        
        public Startup(IConfiguration Configuration) => _Configuration = Configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WebStoreDB>(opt => opt.UseSqlServer(_Configuration.GetConnectionString("Default")));
            services.AddTransient<WebStoreDbInitializer>();
            services.AddControllersWithViews();
            services.AddTransient<IWorkersData, WorkersDataService>();
            services.AddTransient<IProductsData, SqlProductData>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, WebStoreDbInitializer db)
        {
            db.Initialize();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }

            app.UseRouting();

            app.UseStaticFiles();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/home", async context => await context.Response.WriteAsync(_Configuration["Greetings"]));

                endpoints.MapControllerRoute(
                    name:"default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
