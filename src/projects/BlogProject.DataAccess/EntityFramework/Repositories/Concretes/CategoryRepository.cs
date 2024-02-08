using BlogProject.Core.DataAccess.Base.Repositories;
using BlogProject.DataAccess.EntityFramework.Contexts;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete;

namespace BlogProject.DataAccess.EntityFramework.Repositories.Concretes
{
    public class CategoryRepository : EfRepositoryBase<Category, Guid, BlogProjectDbContext>, ICategoryRepository
    {
        public CategoryRepository(BlogProjectDbContext context) : base(context)
        {
        }
    }
}
