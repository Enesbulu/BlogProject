using AutoMapper;
using BlogProject.Business.Abstracts;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.DataAccess.Base.Paging;
using BlogProject.Core.Entities.Dtos;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete.Entities;
using System.Net;

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

        /// <summary>
        /// Asenkron olarak Category ekleme metodu.
        /// </summary>
        /// <param name="categoryAddDto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CustomResponseDto<CategoryGetDto>> AddAsync(CategoryAddDto categoryAddDto,
            CancellationToken cancellationToken = default)
        {
            Category category = _mapper.Map<Category>(categoryAddDto);
            Category addedCategory = await _categoryRepository.AddAsync(category);
            CategoryGetDto result = _mapper.Map<CategoryGetDto>(addedCategory);

            return CustomResponseDto<CategoryGetDto>.Success(statusCode: (int)HttpStatusCode.OK, isSuccess: true,
                data: result);
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


        /// <summary>
        /// İsime göre Category arama için asenkron metod.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CustomResponseDto<CategoryGetDto>> GetByNameAsync(string name,
            CancellationToken cancellationToken = default)
        {
            Category? result = await _categoryRepository.GetAsync(c => c.Name == name, include: null,
                withDeleted: false, enableTracking: true, cancellationToken: cancellationToken);
            CategoryGetDto mappedCategoryGetDto = _mapper.Map<CategoryGetDto>(result);

            return CustomResponseDto<CategoryGetDto>.Success(isSuccess: true, statusCode: (int)HttpStatusCode.OK,
                data: mappedCategoryGetDto);

        }

        /// <summary>
        /// Sayfalama işlemi için asekron metod.
        /// </summary>
        /// <param name="pageRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CustomResponseDto<GetListResponse<CategoryListDto>>> GetListPaginateAsync(
            PageRequest pageRequest, CancellationToken cancellationToken = default)
        {
            IPaginate<Category> result = await _categoryRepository.GetListPaginateAsync(index: pageRequest.Index,
                size: pageRequest.Size,
                cancellationToken: cancellationToken);
            GetListResponse<CategoryListDto> mappedResult = _mapper.Map<GetListResponse<CategoryListDto>>(result);

            return CustomResponseDto<GetListResponse<CategoryListDto>>.Success(statusCode: (int)HttpStatusCode.OK,
                data: mappedResult, isSuccess: true);
        }

        /// <summary>
        /// Category silme işlemi için yazılmış aseknron metod.
        /// </summary>
        /// <param name="categoryDeleteDto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CustomResponseDto<CategoryGetDto>> DeleteAsync(CategoryDeleteDto categoryDeleteDto,
            CancellationToken cancellationToken = default)
        {
            Category category = _mapper.Map<Category>(categoryDeleteDto);
            Category deletedCategory = await _categoryRepository.DeleteAsync(category);
            CategoryGetDto result = _mapper.Map<CategoryGetDto>(deletedCategory);

            return CustomResponseDto<CategoryGetDto>.Success(statusCode: (int)HttpStatusCode.OK,
                data: result, isSuccess: true);
        }
    }
}

