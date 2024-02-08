namespace BlogProject.Core.Entities.Base.Abstract
{
    public interface IAuditable
    {
        string CreatedBy {  get; set; }
        string? ModifiedBy { get; set; }
        string? DeletedBy{ get; set; }
    }
}
