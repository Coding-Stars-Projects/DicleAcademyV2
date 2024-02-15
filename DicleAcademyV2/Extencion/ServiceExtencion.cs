using Entities.ModelsDto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repositories.EF_Core;
using System.ComponentModel.Design;
using System.Reflection;

namespace DicleAcademyV2.Extencion
{
    public static class ServiceExtencion
    {
        public static void ConfiguratioSQLContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Institutional")));
        }
        public static void ConfiguerRepostoryManager(this IServiceCollection services)
        {
           //repostory Referanslar
        }
        public static void ConfiguerServiceManager(this IServiceCollection services)
        { // service referanslar

        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>
                (
                    opts =>
                    {
                        opts.Password.RequireDigit = true;
                        opts.Password.RequireLowercase = true;
                        opts.Password.RequireUppercase = true;
                        opts.Password.RequireNonAlphanumeric = true;
                        opts.Password.RequiredLength = 8;

                        opts.User.RequireUniqueEmail = true;

                    }
                ).AddEntityFrameworkStores<RepositoryContext>()
                .AddDefaultTokenProviders();
        }
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
