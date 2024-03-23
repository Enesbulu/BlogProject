using BlogProject.Entities.Concrete.AuthEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.AuthorizationConfigurations
{
    public class UserLoginConfiguraiton : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            builder.HasKey(ul => new { ul.LoginProvider, ul.ProviderKey });

            builder.Property(ul => ul.LoginProvider).HasMaxLength(128);
            builder.Property(ul => ul.ProviderKey).HasMaxLength(128);

            builder.ToTable("UserLogins");

        }
    }
}
