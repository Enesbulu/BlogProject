using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.DataAccess.EntityFramework.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlogProject.DataAccess.EntityFramework.Contexts
{
    public class BlogProjectDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BlogProjectDbContext(DbContextOptions dbContextOptions, IHttpContextAccessor httpContextAccessor) : base(dbContextOptions)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.RegisterAllEntities<Entity>(Assembly.GetExecutingAssembly());
            modelBuilder.RegisterAllConfigurations(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is Entity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow;
                var user = _httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "anonymous";

                if (entity.State == EntityState.Added)
                {
                    ((Entity)entity.Entity).CreatedBy = user;
                    ((Entity)entity.Entity).CreatedDate = now;
                }

                ((Entity)entity.Entity).ModifiedBy = user;
                ((Entity)entity.Entity).ModifiedDate = now;
            }
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is Entity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow;
                var user = _httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "anonymous";

                if (entity.State == EntityState.Added)
                {
                    ((Entity)entity.Entity).CreatedBy = user;
                    ((Entity)entity.Entity).CreatedDate = now;
                }

                ((Entity)entity.Entity).ModifiedBy = user;
                ((Entity)entity.Entity).ModifiedDate = now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
