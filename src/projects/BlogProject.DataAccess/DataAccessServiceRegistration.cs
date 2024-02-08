using BlogProject.DataAccess.EntityFramework.Contexts;
using BlogProject.DataAccess.EntityFramework.QueryLogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlogProject.DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogProjectDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString"), m => m.MigrationsAssembly("BlogProject.DataAccess")).LogTo(msg => EntityFrameworkQueryLog.LogQuery(msg), LogLevel.Information)
            );

            return services;
        }
    }
}
