namespace BlogProject.Businness.Dtos.Article
{
    public class ArticleAddDto
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
    }
}
