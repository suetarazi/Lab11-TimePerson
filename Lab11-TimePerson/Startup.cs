using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lab11_TimePerson
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Sue - add library - dependency for MVC
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //allows us to se CSS/JS/CSV files, images, etc.
            app.UseStaticFiles();
            app.UseRouting();

            //set our default routing for our MVC app
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default", 
                    "{controller=Home}/{action=Index}/{ id?}");
                 
            });
        }
    }
}
