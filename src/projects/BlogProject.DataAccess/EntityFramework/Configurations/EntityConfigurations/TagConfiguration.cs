using BlogProject.Core.DataAccess.Base.Configurations;
using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.EntityConfigurations
{
    public class TagConfiguration : BaseConfiguration<Tag, Guid>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);

            //Özellikler
            builder.Property(t => t.Name).HasColumnName(ColumNameConstants.TAG_NAME).IsRequired(true)
                .HasMaxLength(LengthContraints.TAG_NAME_MAX_LENGTH);
            //builder.Property(t => t.ArticleTags).IsRequired(true).HasColumnName(ColumNameConstants.ARTICLE_TAGS);

            builder.ToTable(TableNameConstants.TAG);
        }
    }
}
