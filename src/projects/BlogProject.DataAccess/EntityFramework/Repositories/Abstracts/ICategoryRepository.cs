using BlogProject.Core.DataAccess.Base.Repositories;
using BlogProject.Entities.Concrete.Entities;


namespace BlogProject.DataAccess.EntityFramework.Repositories.Abstracts
{
    public interface ICategoryRepository : IAsyncRepository<Category, Guid>
    {
    }
}
