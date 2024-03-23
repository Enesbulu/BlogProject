using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.AuthEntities;
using static BlogProject.Core.Entities.ConplexType.Enums;

namespace BlogProject.Entities.Concrete.Entities
{
    public class CorrectionRequest : Entity<Guid>
    {

        public Guid ArticleId { get; set; }
        public Guid UserId { get; set; }
        public required string RequestContent { get; set; } = string.Empty;
        public required CorrectionRequestStatus Status { get; set; } = CorrectionRequestStatus.None;

        // İlişkiler
        public Article Article { get; set; }
        public User User { get; set; }

        public CorrectionRequest()
        {

        }

        public CorrectionRequest(Guid articleId, Guid userId, string requestContent, CorrectionRequestStatus status)
        {
            ArticleId = articleId;
            UserId = userId;
            RequestContent = requestContent;
            Status = status;
        }
    }
}
