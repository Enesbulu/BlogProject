using BlogProject.Core.DataAccess.Base.Repositories;
using BlogProject.DataAccess.EntityFramework.Contexts;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete.Entities;

namespace BlogProject.DataAccess.EntityFramework.Repositories.Concretes
{
    public class ArticleRepository : EfRepositoryBase<Article, Guid, BlogProjectDbContext>, IArticleRepository
    {
        public ArticleRepository(BlogProjectDbContext context) : base(context)
        {
        }
    }
}
