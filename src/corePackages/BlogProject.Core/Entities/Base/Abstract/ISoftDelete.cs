namespace BlogProject.Core.Entities.Base.Abstract
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
