using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Jeopicodus.Models;

namespace Jeopicodus
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
                services
                .AddDbContext<JeopicodusContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString("MyDbConnection")));
            else{
            services.AddEntityFrameworkMySql()
                .AddDbContext<JeopicodusContext>(options => options
                .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));
            }
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            Console.WriteLine("ERROR RIGHT HERE");
            services.BuildServiceProvider().GetService<JeopicodusContext>().Database.Migrate();

            // services.AddIdentity<ApplicationUser, IdentityRole>()
            //     .AddEntityFrameworkStores<JeopicodusContext>()
            //     .AddDefaultTokenProviders();
            // Console.WriteLine("ERROR HERE");
            // services.Configure<IdentityOptions>(options =>
            // {
            //     options.Password.RequireDigit = false;
            //     options.Password.RequiredLength = 0;
            //     options.Password.RequireLowercase = false;
            //     options.Password.RequireNonAlphanumeric = false;
            //     options.Password.RequireUppercase = false;
            //     options.Password.RequiredUniqueChars = 0;
            // });


            // services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        // {
        //     if (env.IsDevelopment())
        //     {
        //         app.UseDatabaseErrorPage();
        //     }
        //     else
        //     {
        //         app.UseDeveloperExceptionPage();
        //         app.UseExceptionHandler("/Home/Error");
        //         // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //         app.UseHsts();
        //     }

        //     // app.UseHttpsRedirection();
        //     //app.UseStaticFiles();
        //     app.UseCookiePolicy();

        //     app.UseAuthentication();

        //     app.UseMvc(routes =>
        //     {
        //         routes.MapRoute(
        //             name: "default",
        //             template: "{controller=Home}/{action=Index}/{id?}");
        //     });

        //     app.UseSignalR(routes =>
        //     {
        //         routes.MapHub<GameHub>("/gamehub");
        //     });
        // }
    }
}
