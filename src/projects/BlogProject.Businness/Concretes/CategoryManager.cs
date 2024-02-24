using System.Net;
using AutoMapper;
using BlogProject.Businness.Abstracts;
using BlogProject.Businness.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete;

namespace BlogProject.Businness.Concretes
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

        public async Task<CustomResponseDto<IList<CategoryListDto>>> GetListAsync(CancellationToken cancellationToken = default)
        {
            IList<Category> result = await _categoryRepository.GetListAsync(cancellationToken: cancellationToken);
            List<CategoryListDto> mappedResult = _mapper.Map<List<CategoryListDto>>(result);
            return CustomResponseDto<IList<CategoryListDto>>.Success(statusCode: (int)HttpStatusCode.OK,
                isSuccess: true,data: mappedResult);
        }
    }
}
