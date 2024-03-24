using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.AuthEntities;

namespace BlogProject.Entities.Concrete.Entities
{
    public class Comment : Entity<Guid>
    {

        public required Guid ArticleId { get; set; }
        public required Guid UserId { get; set; }
        public required Guid ApprovedUserId { get; set; }
        public required string Content { get; set; } = string.Empty;
        public required bool IsPublished { get; set; } = false;
        public required bool IsApproved { get; set; }=false;

        // İlişkiler
        public Article Article { get; set; }
        public User User { get; set; }

        public Comment()
        {
        }

        public Comment(Guid articleId, Guid userId, string content, Guid ApprovedUserId, bool isPublished, bool isApproved)
        {
            ArticleId = articleId; 
            UserId = userId;
            Content = content;
            ApprovedUserId = ApprovedUserId;
            IsPublished = isPublished;
            IsApproved = isApproved;
        }


    }
}
