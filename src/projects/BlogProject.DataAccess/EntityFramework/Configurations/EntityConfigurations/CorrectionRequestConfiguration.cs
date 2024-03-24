using BlogProject.Core.DataAccess.Base.Configurations;
using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete.AuthEntities;
using BlogProject.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LengthContraints = BlogProject.DataAccess.EntityFramework.Constants.LengthContraints;

namespace BlogProject.DataAccess.EntityFramework.Configurations.EntityConfigurations
{
    public class CorrectionRequestConfiguration : BaseConfiguration<CorrectionRequest, Guid>
    {
        public override void Configure(EntityTypeBuilder<CorrectionRequest> builder)
        {
            base.Configure(builder);

            ///Properties
            builder.Property(cr => cr.ArticleId).HasColumnName(ColumNameConstants.ARTICLE_ID).IsRequired(true)
                .HasMaxLength(LengthContraints.CORRECTION_REQUEST_ARTICLEID_MAXLENGTH);
            builder.Property(cr => cr.UserId).HasColumnName(ColumNameConstants.USER_ID).IsRequired(true).HasMaxLength(LengthContraints.CORRECTION_REQUEST_USERID_MAXLENGTH);
            builder.Property(cr => cr.RequestContent).HasColumnName(ColumNameConstants.REQUEST_CONTENT)
                .HasMaxLength(LengthContraints.CORRECTION_REQUEST_MAXLENGTH).IsRequired(true);
            builder.Property(cr => cr.Status).IsRequired(true).HasColumnName(ColumNameConstants.STATUS);

            //
            builder.HasOne<Article>(cr => cr.Article).WithMany(a => a.CorrectionRequest)
                .HasForeignKey(cr => cr.ArticleId);
            builder.HasOne<User>(cr => cr.User).WithMany(u => u.CorrectionRequests).HasForeignKey(cr => cr.UserId);

            builder.ToTable(TableNameConstants.CORRECTION_REQUEST);

        }
    }
}
