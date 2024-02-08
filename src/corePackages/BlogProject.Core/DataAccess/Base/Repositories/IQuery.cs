namespace BlogProject.Core.DataAccess.Base.Repositories
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}
