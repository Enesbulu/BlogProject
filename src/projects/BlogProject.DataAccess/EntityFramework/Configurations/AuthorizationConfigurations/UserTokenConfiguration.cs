using BlogProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.AuthorizationConfigurations
{
    public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Name });

            builder.Property(ut => ut.LoginProvider).HasMaxLength(128);
            builder.Property(ut => ut.Name).HasMaxLength(128);

            builder.ToTable("USerTokens");
        }
    }
}
