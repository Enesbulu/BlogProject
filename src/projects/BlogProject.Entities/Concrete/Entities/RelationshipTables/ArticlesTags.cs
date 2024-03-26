namespace BlogProject.Entities.Concrete.Entities.RelationshipTables
{
    public class ArticlesTags
    {
        public Guid ArticleId{ get; set; }
        public Guid TagId{ get; set; }
        public Article Article { get; set; }
        public Tag Tag { get; set; }
    }
}
