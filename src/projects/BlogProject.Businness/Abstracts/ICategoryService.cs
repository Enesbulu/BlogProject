using BlogProject.Businness.Dtos.Categories;
using BlogProject.Core.Business.Concrete;

namespace BlogProject.Businness.Abstracts
{
    public interface ICategoryService
    {
        Task<CustomResponseDto<IList<CategoryListDto>>> GetListAsync(CancellationToken cancellationToken = default);
    }
}
