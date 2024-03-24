using BlogProject.Core.DataAccess.Base.Configurations;
using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete.AuthEntities;
using BlogProject.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.EntityConfigurations
{
    public class CommentConfiguration : BaseConfiguration<Comment, Guid>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Content).HasColumnName(ColumNameConstants.COMMENT_CONTENT).IsRequired(true)
                .HasMaxLength(LengthContraints.COMMENT_CONTENT_MAXLENGTH);
            builder.Property(c => c.ArticleId).IsRequired(true).HasColumnName(ColumNameConstants.ARTICLE_ID);
            builder.Property(c => c.UserId).IsRequired(true).HasColumnName(ColumNameConstants.USER_ID);
            builder.Property(c => c.ApprovedUserId).IsRequired(true).HasColumnName(ColumNameConstants.APPROVED_USER_ID);
            builder.Property(c => c.IsPublished).IsRequired(true)
                .HasColumnName(ColumNameConstants.IS_PUBLISHED);
            builder.Property(c => c.IsApproved).IsRequired(true).HasColumnName(ColumNameConstants.IS_APPROVED);

            //
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comment).HasForeignKey(c => c.ArticleId);
            builder.HasOne<User>(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);
            builder.HasOne<User>(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.ApprovedUserId);   //?? Onay veren kişinin Id bilgisi için!



            builder.ToTable(TableNameConstants.COMMENT);
        }
    }
}
