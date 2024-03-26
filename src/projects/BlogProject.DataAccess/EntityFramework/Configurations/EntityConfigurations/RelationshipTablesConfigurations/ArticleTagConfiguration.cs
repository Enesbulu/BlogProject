using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete.Entities.RelationshipTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.EntityConfigurations.RelationshipTablesConfigurations
{
    public class ArticleTagConfiguration : IEntityTypeConfiguration<ArticlesTags>
    {
        public void Configure(EntityTypeBuilder<ArticlesTags> builder)
        {
            builder.ToTable(TableNameConstants.ARTICLE_TAG);


            //Many-to-many yapılandırılması -- İlişkiler
            builder.HasKey(at => new { at.ArticleId, at.TagId });


            builder.HasOne(at => at.Article).WithMany(a => a.ArticleTags).HasForeignKey(at => at.ArticleId);

            builder.HasOne(at => at.Tag).WithMany(r => r.ArticleTags).HasForeignKey(at => at.TagId);

        }

    }
}
