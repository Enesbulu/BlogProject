namespace BlogProject.Business.Dtos.Categories
{
    public class CategoryDeleteDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
