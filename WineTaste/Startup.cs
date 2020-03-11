using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WineTaste.Models;
using WineTaste.Models.ModelsImpl;

namespace WineTaste
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.Add(new ServiceDescriptor(typeof(ICategoryRepository),
                new CategoryDataAccess(
                    Configuration.GetConnectionString("DefaultConnection"))));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseMvc(route =>
            {
                route.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async context => { await context.Response.WriteAsync("Hello World"); });
        }
    }
}