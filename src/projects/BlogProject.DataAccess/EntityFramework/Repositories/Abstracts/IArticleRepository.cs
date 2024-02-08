using BlogProject.Core.DataAccess.Base.Repositories;
using BlogProject.Entities.Concrete;

namespace BlogProject.DataAccess.EntityFramework.Repositories.Abstracts
{
    public interface IArticleRepository:IAsyncRepository<Article, Guid>
    {
    }
}
