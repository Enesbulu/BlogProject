using BlogProject.Core.Entities.Base.Abstract;

namespace BlogProject.Entities.Concrete
{
    public class Category : Entity<Guid>
    {
        public required string Name {  get; set; }
        public required string Description { get; set; }
        public  ICollection<Article> Articles { get; set; }

        public Category()
        {
            Articles = new HashSet<Article>();
        }

        public Category(Guid id,string name, string description ):this() 
        {
            Id = id;
            Name = name;
            Description = description;
                        
        }
    }
}
