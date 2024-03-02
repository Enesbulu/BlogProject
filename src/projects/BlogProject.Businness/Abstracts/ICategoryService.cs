using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;

namespace BlogProject.Business.Abstracts
{
    public interface ICategoryService
    {
        Task<CustomResponseDto<IList<CategoryListDto>>> GetListAsync(CancellationToken cancellationToken = default);
        Task<CustomResponseDto<CategoryGetDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<CustomResponseDto<CategoryGetDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    }
}
