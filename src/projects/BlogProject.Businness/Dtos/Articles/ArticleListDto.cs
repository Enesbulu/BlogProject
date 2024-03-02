namespace BlogProject.Business.Dtos.Article
{
    public class ArticleListDto
    {
        public required Guid Id { get; set; }
        public required string  Title{ get; set; }
        public required string Content{ get; set; }
        public required string Thumbnail { get; set; }
        public int  ViewCount{ get; set; }
        public int CommentCount { get; set; }
    }
}
