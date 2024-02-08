using static BlogProject.Core.Entities.ConplexType.Enums;

namespace BlogProject.Core.Entities.Base.Abstract
{
    public abstract class Entity : IEntity<Guid>, ISoftDelete, IAuditable, IHasTimeStamps
    {
        public Guid Id { get; set; }
        public RecordStatu Statu { get; set; } = RecordStatu.Active;
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = "System";
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }


    }

    public abstract class Entity<TKey>: IEntity<TKey>, ISoftDelete, IAuditable, IHasTimeStamps where TKey: IEquatable<TKey>
    {
        public required TKey Id { get; set; }
        public RecordStatu Statu { get; set; } = RecordStatu.Active;
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = "System";
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }


    }
}
