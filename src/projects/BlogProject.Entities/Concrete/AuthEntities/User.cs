using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.Entities;
using Microsoft.AspNetCore.Identity;
using static BlogProject.Core.Entities.ComplexTypes.Enums;

namespace BlogProject.Entities.Concrete.AuthEntities
{
    public class User : IdentityUser<Guid>, IEntity<Guid>, IAuditable, IHasTimestamps
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }

        // Interface Implementations
        public RecordStatus Status { get; set; } = RecordStatus.Active;
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }

        // --- İLİŞKİLER (GÜNCELLENDİ) ---

        // Bir kullanıcının YAZDIĞI makaleler
        public ICollection<Article> ArticlesAuthored { get; set; } = new HashSet<Article>();

        // Bir kullanıcının EDİTLEDİĞİ makaleler (Opsiyonel)
        public ICollection<Article> ArticlesEdited { get; set; } = new HashSet<Article>();

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public ICollection<CorrectionRequest> CorrectionRequests { get; set; } = new HashSet<CorrectionRequest>();
    }

}
