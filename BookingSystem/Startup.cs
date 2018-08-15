using BookingSystem.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ApplicationUser = BookingSystem.Models.Entities.ApplicationUser;

namespace BookingSystem
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

            var connectionstring = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BookingSystemDbContext>(o => o.UseSqlServer(connectionstring));

            //var builder = services.AddIdentityCore<ApplicationUser>(o =>

            //{
            //    // configure identity options
            //    o.Password.RequireDigit = false;
            //    o.Password.RequireLowercase = false;
            //    o.Password.RequireUppercase = false;
            //    o.Password.RequireNonAlphanumeric = false;
            //    o.Password.RequiredLength = 6;

            //});
            //builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            //builder.AddEntityFrameworkStores<BookingSystemDbContext>().AddDefaultTokenProviders();

            //services.AddDefaultIdentity<ApplicationUser,Role,UserRole>()
            //.AddEntityFrameworkStores<BookingSystemDbContext>();

            services.AddIdentity<ApplicationUser, Role>()
                .AddEntityFrameworkStores<BookingSystemDbContext>()
                .AddDefaultTokenProviders();

            var secretKey = Configuration["Jwt:SecretKey"];
            var issuer = Configuration["Jwt:JwtIssuer"];
            var audience = Configuration["Jwt:JwtAudience"];

            services.AddAuthentication().AddJwtBearer
            (options => options.TokenValidationParameters = 
                new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = issuer,
                    ValidAudience = audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                });

            services.AddAuthorization(cfg =>
            {
                cfg.AddPolicy("Administrator", p => p.RequireRole("Administrator", "True"));
            });

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
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
