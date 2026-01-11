// ...existing code...
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlogProject.DataAccess.DesignTime
{
    // Design-time factory so EF Core tools (migrations, update-database) can create the DbContext
    public class BlogProjectDbContextFactory : IDesignTimeDbContextFactory<BlogProject.DataAccess.EntityFramework.Contexts.BlogProjectDbContext>
    {
        public BlogProject.DataAccess.EntityFramework.Contexts.BlogProjectDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogProject.DataAccess.EntityFramework.Contexts.BlogProjectDbContext>();

            // Matches the connection string used by the MVC project's appsettings.json.
            // For security/portability you can read this from environment variables instead.
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("BlogProject.DataAccess"));

            // Provide a simple IHttpContextAccessor required by the DbContext constructor.
            var httpContextAccessor = new HttpContextAccessor();

            return new BlogProject.DataAccess.EntityFramework.Contexts.BlogProjectDbContext(optionsBuilder.Options, httpContextAccessor);
        }
    }
}
// ...existing code...