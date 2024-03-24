using BlogProject.Core.DataAccess.Base.Repositories;
using BlogProject.DataAccess.EntityFramework.Contexts;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete.Entities;

namespace BlogProject.DataAccess.EntityFramework.Repositories.Concretes
{
    public class CommentRepository : EfRepositoryBase<Comment, Guid, BlogProjectDbContext>, ICommentRepository
    {
        public CommentRepository(BlogProjectDbContext context) : base(context)
        {
        }
    }
}
