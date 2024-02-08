using BlogProject.Businness.Abstracts;
using BlogProject.Businness.Concretes;
using BlogProject.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BlogProject.Businness
{
    public static class BussinessServiceRegistration
    {
        public static IServiceCollection AddBussinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScopedWithManagers(typeof(IArticleService).Assembly);

            return services;
        }
        public static IServiceCollection AddScopedWithManagers(this IServiceCollection services, Assembly assembly)
        {
            var serviceTypes = assembly.GetTypes()
                                       .Where(t => t.IsInterface && t.Name.EndsWith("Service"));

            foreach (var serviceType in serviceTypes)
            {
                var managerTypeName = serviceType.Name.Replace("Service", "Manager").ReplaceFirst("I", "");
                var managerType = assembly.GetTypes().SingleOrDefault(t => t.Name == managerTypeName);

                if (managerType != null)
                {
                    services.AddScoped(serviceType, managerType);
                }
            }

            return services;
        }
    }
}
