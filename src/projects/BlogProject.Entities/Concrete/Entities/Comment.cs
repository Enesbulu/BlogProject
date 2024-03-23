using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.AuthEntities;

namespace BlogProject.Entities.Concrete.Entities
{
    public class Comment : Entity<Guid>
    {

        public Guid ArticleId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; }

        // İlişkiler
        public Article Article { get; set; }
        public User User { get; set; }

        public Comment()
        {

        }

        public Comment(Guid articleId, Guid userId, string content)
        {
            ArticleId = articleId;
            UserId = userId;
            Content = content;
        }


    }
}
