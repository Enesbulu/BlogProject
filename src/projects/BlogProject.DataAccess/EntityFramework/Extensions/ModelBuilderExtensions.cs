using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlogProject.DataAccess.EntityFramework.Extensions
{
    public static class ModelBuilderExtensions
    {
        private const string _entityNameSpace = "BlogProject.Entities.Concrete";
        public static void RegisterAllEntities<T>(this ModelBuilder modelBuilder, params Assembly[] assemblies)
        {
            var types = assemblies.SelectMany(a => a.GetExportedTypes())
                          .Where(c => c.IsClass &&
                                      !c.IsAbstract &&
                                      c.IsPublic &&
                                      c.Namespace != null &&
                                      c.Namespace.StartsWith(_entityNameSpace) &&
                                      typeof(T).IsAssignableFrom(c));


            foreach (var type in types)
                modelBuilder.Entity(type);

        }

        public static void RegisterAllConfigurations(this ModelBuilder modelBuilder, params Assembly[] assemblies)
        {
            assemblies = assemblies.Length != 0 ? assemblies : [Assembly.GetExecutingAssembly()];
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public static void ConfigureAllDecimalFields(this ModelBuilder modelBuilder)
        {
            var decimals = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(decimal));
            const string DecimalConfig = "decimal(18, 2)";
            foreach (var property in decimals)
                property.SetColumnType(DecimalConfig);
        }

    }
}
