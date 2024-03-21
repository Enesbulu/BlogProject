using System.ComponentModel;

namespace BlogProject.Business.Dtos.Articles
{
    public class ArticleUpdateDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
    }
}
