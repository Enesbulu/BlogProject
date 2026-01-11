using BlogProject.Core.Entities.Base.Abstract;
using BlogProject.Entities.Concrete.Entities.RelationshipTables;

namespace BlogProject.Entities.Concrete.Entities
{
    public class Tag : Entity<Guid>
    {
        public required string Name { get; set; } 
        public ICollection<ArticlesTags> ArticleTags { get; set; } = new HashSet<ArticlesTags>();

        public Tag() { }

        public Tag(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
