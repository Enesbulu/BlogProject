namespace BlogProject.Core.Entities.Base.Abstract
{
    public interface IHasTimestamps:ISoftDelete
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
