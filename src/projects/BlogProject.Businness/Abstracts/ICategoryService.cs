using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.Entities.Dtos;

namespace BlogProject.Business.Abstracts
{
    public interface ICategoryService
    {
        Task<CustomResponseDto<IList<CategoryListDto>>> GetListAsync(CancellationToken cancellationToken = default);
        Task<CustomResponseDto<CategoryGetDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<CustomResponseDto<CategoryGetDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<CustomResponseDto<CategoryGetDto>> AddAsync(CategoryAddDto categoryAddDto, CancellationToken cancellationToken = default);
        Task<CustomResponseDto<CategoryGetDto>> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<CustomResponseDto<GetListResponse<CategoryListDto>>> GetListPaginateAsync(PageRequest pageRequest, CancellationToken cancellationToken = default);
        Task<CustomResponseDto<CategoryGetDto>> DeleteAsync(CategoryDeleteDto categoryDeleteDto, CancellationToken cancellationToken = default);


    }
}
