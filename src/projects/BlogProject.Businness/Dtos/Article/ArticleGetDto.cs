namespace BlogProject.Businness.Dtos.Article
{
    public class ArticleGetDto
    {
        public required Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Thumbnail { get; set; }
        public required Guid CategoryId { get; set; }

    }
}
