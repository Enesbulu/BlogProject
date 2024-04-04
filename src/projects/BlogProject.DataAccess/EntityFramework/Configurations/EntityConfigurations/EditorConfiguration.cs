using BlogProject.DataAccess.EntityFramework.Constants;
using BlogProject.Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.DataAccess.EntityFramework.Configurations.EntityConfigurations
{
    public class EditorConfiguration :IEntityTypeConfiguration<Editor>
    {
        public void Configure(EntityTypeBuilder<Editor> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.FirstName)
                .IsRequired(true)
                .HasMaxLength(LengthContraints.NAME_MAX_LENGTH).HasColumnName(ColumNameConstants.EDITOR_FIRST_NAME);

            builder.Property(e => e.LastName)
                .IsRequired(true)
                .HasMaxLength(LengthContraints.LAST_NAME_MAX_LENGTH).HasColumnName(ColumNameConstants.EDITOR_LAST_NAME);

       
            // Tablo adını belirleyebilirsiniz (opsiyonel)
            builder.ToTable(TableNameConstants.EDITOR);
            builder.HasData(data: GetSeeds());
        }
        private static HashSet<Editor> GetSeeds()
        {
            HashSet<Editor> authors =
            [
                new Editor
                {
                    Id = Guid.Parse("8fc0e49b-fc50-452e-825c-722f95163ea6"), FirstName = "Yaver", LastName = "Koçan",
                    Email = "yaver_kocan.@mail.com"
                },
          
            ];

            return authors;
        }
    }
}
