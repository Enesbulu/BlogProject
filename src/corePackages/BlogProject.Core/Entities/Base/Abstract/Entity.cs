using static BlogProject.Core.Entities.ComplexTypes.Enums;

namespace BlogProject.Core.Entities.Base.Abstract
{
    public abstract class Entity : IEntity<Guid>, ISoftDelete, IAuditable, IHasTimestamps
    {
        public Guid Id { get; set; }
        public RecordStatus Statu { get; set; } = RecordStatus.Active;
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = "System";
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }


    }

    public abstract class Entity<TKey>: IEntity<TKey>, ISoftDelete, IAuditable, IHasTimestamps where TKey: IEquatable<TKey>
    {
        public required TKey Id { get; set; }
        public RecordStatus Statu { get; set; } = RecordStatus.Active;
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = "System";
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }


    }
}
