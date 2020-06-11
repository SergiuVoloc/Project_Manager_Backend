using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Evidenta.Context;
using Microsoft.AspNetCore.Identity;
using Evidenta.Services.Interfaces;
using Evidenta.Repository.Interfaces;
using Evidenta.Repository;
using Evidenta.Services;

namespace Evidenta
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

            services.AddTransient<IAuthentificationServices, AuthentificationServices>();

            services.AddTransient<IDisciplineServices, DisciplineServices>();
            services.AddTransient<IDisciplineRepository, DisciplineRepository>();

            services.AddTransient<IProjectServices, ProjectServices>();
            services.AddTransient<IProjectRepository, ProjectRepository>();

            services.AddTransient<IStudentServices, StudentServices>();
            services.AddTransient<IStudentRepository, StudentRepository>();

            services.AddTransient<ITeacherServices, TeacherServices>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();


            services.AddRazorPages();
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<DefaultContext>();
            services.AddControllersWithViews();
            
            var connection = @"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<DefaultContext>
                (options => options.UseSqlServer(connection));
            services.Configure<IdentityOptions>(options => {
                //Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 8;

                //Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                


            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
