using BlogProject.Entities.Concrete.AuthEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.AuthorizationConfigurations
{
    public class RoleClaimConfiguration:IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            builder.HasKey(rc => rc.Id);
            builder.ToTable("RoleClaim");
        }
    }
}
