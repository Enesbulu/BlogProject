using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.AuthEntities;
using BlogProject.Entities.Concrete.Entities.RelationshipTables;

namespace BlogProject.Entities.Concrete.Entities
{
    public class Article : Entity<Guid>
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Thumbnail { get; set; } // Resim yolu
        public DateTime Date { get; set; }
        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;

        // --- İLİŞKİLER ---

        // Kategori İlişkisi
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        // Yazar İlişkisi (User tablosuna gider)
        public Guid AuthorId { get; set; } // Makaleyi yazan User'ın ID'si
        public User Author { get; set; }   // Navigation Property

        // Editör İlişkisi (User tablosuna gider, NULL olabilir çünkü her makale editlenmez)
        public Guid? EditorId { get; set; }
        public User? Editor { get; set; }

        // Diğer İlişkiler
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public ICollection<CorrectionRequest> CorrectionRequests { get; set; } = new HashSet<CorrectionRequest>();
        public ICollection<ArticlesTags> ArticleTags { get; set; } = new HashSet<ArticlesTags>();

       
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
