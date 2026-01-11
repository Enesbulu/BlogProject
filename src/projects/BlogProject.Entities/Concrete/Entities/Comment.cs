using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.AuthEntities;

namespace BlogProject.Entities.Concrete.Entities
{
    public class Comment : Entity<Guid>
    {
        public required string Content { get; set; } = string.Empty;
        public required bool IsPublished { get; set; } = false;
        public required bool IsApproved { get; set; } = false;


        // Yorum hangi makaleye yapıldı?
        public required Guid ArticleId { get; set; }
        public Article Article { get; set; }


        // Yorumu kim yazdı?
        public required Guid UserId { get; set; }
        public User User { get; set; }

        // Yorumu kim onayladı? (Admin/Editor olabilir - User tablosunda)
        public Guid? ApproverId { get; set; }
        public User? Approver { get; set; }

        // İlişkiler

        public Comment()
        {
        }

        public Comment(Guid articleId, Guid userId, string content, Guid ApproverId, bool isPublished, bool isApproved)
        {
            ArticleId = articleId;
            UserId = userId;
            Content = content;
            ApproverId = ApproverId;
            IsPublished = isPublished;
            IsApproved = isApproved;
        }


    }
}
