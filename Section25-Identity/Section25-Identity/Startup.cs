using Core.Entities.IdentityEntities;
using Infrastructure.Data;
using Infrastructure.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using System.Text.Json.Serialization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Collections.Specialized.BitVector32;

namespace Section25_Identity
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(json =>
                json.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            services.AddControllersWithViews();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            //dotnet ef migrations add InitialSetup - p.\Infrastructure\ -s.\Section25 - Identity\
            //dotnet ef database update - p.\Infrastructure\ -s.\Section25 - Identity\
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()
                .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoint => endpoint.MapControllers());
        }
    }
}
