using System.Data.SqlTypes;
using BlogProject.Core.DataAccess.Base.Configurations;
using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete.Entities;
using BlogProject.Entities.Concrete.Entities.RelationshipTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.EntityConfigurations
{
    public class ArticleConfiguration : BaseConfiguration<Article, Guid>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            base.Configure(builder);
            //Özellikler
            builder.Property(x => x.Title).HasColumnName(ColumNameConstants.TITLE).IsRequired(true).HasMaxLength(LengthContraints.TITLE_MAX_LENGTH);
            builder.Property(x => x.Content).HasColumnName(ColumNameConstants.CONTENT).IsRequired(true);
            builder.Property(x => x.Thumbnail).HasColumnName(ColumNameConstants.THUMBNAIL).IsRequired(true).HasMaxLength(LengthContraints.THUMBNAIL_MAX_LENGTH);
            builder.Property(x => x.Date).HasColumnName(ColumNameConstants.DATE).IsRequired(true);
            builder.Property(x => x.ViewCount).HasColumnName(ColumNameConstants.VIEW_COUNT).IsRequired(true);
            builder.Property(x => x.CommentCount).HasColumnName(ColumNameConstants.COMMENT_COUNT).IsRequired(true);
            builder.Property(x => x.CategoryId).HasColumnName(ColumNameConstants.CATEGORY_ID).IsRequired(true);

            //İlişkiler
            builder.HasOne(x => x.Category).WithMany(x => x.Articles).HasForeignKey(x => x.CategoryId);

            builder.ToTable(TableNameConstants.ARTICLE);
            builder.HasData(data: GetSeeds());

        }

        /// <summary>
        /// Temsili-geçici veriler.
        /// </summary>
        /// <returns></returns>
        private static HashSet<Article> GetSeeds()
        {
            HashSet<Article> articles =
            [
                new Article { Id = Guid.NewGuid(), Title = "C# 9.0", Content = "C# 9.0 ile ilgili makaleler", Thumbnail = "csharp.png", Date = DateTime.Now, ViewCount = 100, CommentCount = 10, CategoryId = Guid.Parse("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), CreatedBy = "System", CreatedDate = DateTime.Now },
                new Article { Id = Guid.NewGuid(), Title = "Java 11", Content = "Java 11 ile ilgili makaleler", Thumbnail = "java.png", Date = DateTime.Now, ViewCount = 100, CommentCount = 10, CategoryId = Guid.Parse("c33260dd-b051-4a2d-923a-4c16553e4753"), CreatedBy = "System", CreatedDate = DateTime.Now },
                new Article { Id = Guid.NewGuid(), Title = "Python 3.9", Content = "Python 3.9 ile ilgili makaleler", Thumbnail = "python.png", Date = DateTime.Now, ViewCount = 100, CommentCount = 10, CategoryId = Guid.Parse("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), CreatedBy = "System", CreatedDate = DateTime.Now },
            ];

            return articles;
        }
    }
}
