using BlogProject.Core.Entities.Base.Abstract;

namespace BlogProject.Entities.Concrete
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
        public  Category Category { get; set; }

        public Article()
        {
        }
        public Article(Guid id ,string title, string content, string thumbnail, DateTime date, int viewCount, int commentCount, Guid categoryId):this() 
        {
            Id = id; 
            Title = title;
            Content = content;
            Thumbnail = thumbnail;
            Date = date;
            ViewCount = viewCount;
            CommentCount = commentCount;
            CategoryId = categoryId;
           
        }

    }
}
