using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.EntityConfigurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(a => a.FirstName).HasColumnName(ColumNameConstants.AUTHOR_FIRST_NAME).IsRequired(true)
                .HasMaxLength(LengthContraints.NAME_MAX_LENGTH);
            builder.Property(a => a.LastName).HasColumnName(ColumNameConstants.AUTHOR_LAST_NAME).IsRequired(true)
                .HasMaxLength(LengthContraints.LAST_NAME_MAX_LENGTH);

            builder.ToTable(TableNameConstants.AUTHOR);
            builder.HasData(data: GetSeeds());


        }

        private static HashSet<Author> GetSeeds()
        {
            HashSet<Author> authors =
            [
                new Author
                {
                    Id = Guid.Parse("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), FirstName = "Orhan", LastName = "Balçık",
                    Email = "orhan_balcik.@mail.com"
                },
               
            ];

            return authors;
        }
    }
}
