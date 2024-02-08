using Autofac;
using BlogProject.DataAccess.EntityFramework.Contexts;
using System.Reflection;

namespace BlogProject.DataAccess.EntityFramework.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var mvcAssembly = Assembly.GetExecutingAssembly();
            var repositoryAssembly = Assembly.GetAssembly(typeof(BlogProjectDbContext));

            builder.RegisterAssemblyTypes(mvcAssembly, repositoryAssembly).Where(x=> x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerMatchingLifetimeScope();
        }
    }
}
