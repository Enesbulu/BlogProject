using BlogProject.Core.DataAccess.Base.Constants;
using BlogProject.Core.Entities.Base.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.Core.DataAccess.Base.Configurations
{
    public class BaseConfiguration<T, TKey> : IEntityTypeConfiguration<T>
         where T : Entity<TKey>
         where TKey : IEquatable<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Statu).IsRequired(true).HasConversion<int>();
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(LengthContraints.CreatedByMaxLength).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedDate).IsRequired(true).ValueGeneratedOnAdd();
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(LengthContraints.CreatedByMaxLength);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.isDeleted).IsRequired(true);
            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.DeletedBy).IsRequired(false).HasMaxLength(LengthContraints.CreatedByMaxLength);
            builder.HasQueryFilter(x => !x.isDeleted);
        }
    }
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T>
       where T : Entity
       
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Statu).IsRequired(true).HasConversion<int>();
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(LengthContraints.CreatedByMaxLength).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedDate).IsRequired(true).ValueGeneratedOnAdd();
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(LengthContraints.CreatedByMaxLength);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.isDeleted).IsRequired(true);
            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.DeletedBy).IsRequired(false).HasMaxLength(LengthContraints.CreatedByMaxLength);
            builder.HasQueryFilter(x => !x.isDeleted);
        }
    }
}
