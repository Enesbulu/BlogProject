using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.Entities.RelationshipTables;

namespace BlogProject.Entities.Concrete.Entities
{
    public class Article : Entity<Guid>
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Comment?> Comment { get; set; } = default;
        public IEnumerable<CorrectionRequest?> CorrectionRequest { get; set; } = default;
        public ICollection<ArticlesTags> ArticleTags { get; set; }

        public required Guid AuthorId { get; set; } = default!;
        public Author Author { get; set; }
        public required Guid EditorId { get; set; } = default!;
        public Editor Editor { get; set; }

        //public Guid UserId { get; set; }
        //public User User { get; set; }

        public Article() { }

        public Article(Guid id, string title, string content, string thumbnail, DateTime date, int viewCount, int commentCount, Guid categoryId, ICollection<ArticlesTags> articleTags, Guid authorId, Guid editorId)
        {
            Id = id;
            Title = title;
            Content = content;
            Thumbnail = thumbnail;
            Date = date;
            ViewCount = viewCount;
            CommentCount = commentCount;
            CategoryId = categoryId;
            ArticleTags = articleTags;
            AuthorId = authorId;
            EditorId = editorId;
        }

    }
}
