using BlogProject.Core.DataAccess.Base.Configurations;
using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BlogProject.DataAccess.EntityFramework.Configuraions
{
    public class CategoryConfiguration : BaseConfiguration<Category,Guid>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired(true).HasMaxLength(LengthContraints.NAME_MAX_LENGTH);
            builder.Property(x => x.Description).HasColumnName("Description").IsRequired(true).HasMaxLength(LengthContraints.DESCRIPTION_MAX_LENGTH);
            builder.ToTable(TableNameConstants.CATEGORY);
            builder.HasData(data: GetSeeds());
        }
        private static HashSet<Category> GetSeeds()
        {
            HashSet<Category> categories =
            [
               new Category { Id = Guid.Parse("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), Name = "C#", Description = "C# ile ilgili makaleler", CreatedBy = "System", CreatedDate = DateTime.Now },
                new Category { Id = Guid.Parse("c33260dd-b051-4a2d-923a-4c16553e4753"), Name = "Java", Description = "Java ile ilgili makaleler", CreatedBy = "System", CreatedDate = DateTime.Now },
            ];

            return categories;
        }

    }
}
