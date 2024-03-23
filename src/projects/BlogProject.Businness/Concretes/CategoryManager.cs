using System.Net;
using AutoMapper;
using BlogProject.Business.Abstracts;
using BlogProject.Business.Dtos.Article;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete.Entities;

namespace BlogProject.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<IList<CategoryListDto>>> GetListAsync(
            CancellationToken cancellationToken = default)
        {
            IList<Category> result = await _categoryRepository.GetListAsync(cancellationToken: cancellationToken);
            List<CategoryListDto> mappedResult = _mapper.Map<List<CategoryListDto>>(result);
            return CustomResponseDto<IList<CategoryListDto>>.Success(statusCode: (int)HttpStatusCode.OK,
                isSuccess: true, data: mappedResult);
        }

        public async Task<CustomResponseDto<CategoryGetDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            Category category = _mapper.Map<Category>(categoryUpdateDto);
            Category result = await _categoryRepository.UpdateAsync(category);
            CategoryGetDto mappedResult = _mapper.Map<CategoryGetDto>(result);
            return CustomResponseDto<CategoryGetDto>.Success(statusCode: (int)HttpStatusCode.OK,
                data: mappedResult, isSuccess: true);
        }

        public async Task<CustomResponseDto<CategoryGetDto>> GetByIdAsync(Guid id,
            CancellationToken cancellationToken = default)
        {
            Category? resul = await _categoryRepository.GetAsync(predicate: x => x.Id == id, include: null,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken);
            CategoryGetDto mappedCategoryGetDto = _mapper.Map<CategoryGetDto>(resul);
            return CustomResponseDto<CategoryGetDto>.Success(statusCode: (int)HttpStatusCode.OK,
                data: mappedCategoryGetDto, isSuccess: true);
        }
    }
}

