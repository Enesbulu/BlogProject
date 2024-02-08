namespace BlogProject.Core.Entities.Base.Abstract
{
    public interface IHasTimeStamps:ISoftDelete
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
