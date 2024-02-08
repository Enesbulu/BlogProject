namespace BlogProject.Core.Entities.Base.Abstract
{
    public interface ISoftDelete
    {
        bool isDeleted { get; set; }
    }
}
