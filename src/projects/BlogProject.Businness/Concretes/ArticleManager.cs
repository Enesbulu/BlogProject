using AutoMapper;
using BlogProject.Business.Abstracts;
using BlogProject.Business.Dtos.Article;
using BlogProject.Business.Dtos.Articles;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.DataAccess.Base.Paging;
using BlogProject.Core.Entities.Dtos;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete.Entities;
using System.Net;

namespace BlogProject.Business.Concretes
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;

        public ArticleManager(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<ArticleGetDto>> AddAsync(ArticleAddDto articleAddDto, CancellationToken cancellationToken = default)
        {
            Article article = _mapper.Map<Article>(articleAddDto);
            Article addedArticle = await _articleRepository.AddAsync(article);
            ArticleGetDto result = _mapper.Map<ArticleGetDto>(addedArticle);

            return CustomResponseDto<ArticleGetDto>.Success(statusCode: (int)HttpStatusCode.OK, data: result, true);
        }

        public async Task<CustomResponseDto<ArticleGetDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            Article? result = await _articleRepository.GetAsync(predicate: x => x.Id == id, include: null, withDeleted: false, enableTracking: false, cancellationToken: cancellationToken);
            ArticleGetDto mappedArticleGetDto = _mapper.Map<ArticleGetDto>(result);
            return CustomResponseDto<ArticleGetDto>.Success(statusCode: (int)HttpStatusCode.OK, isSuccess: true, data: mappedArticleGetDto);
        }

        public async Task<CustomResponseDto<ArticleGetDto>> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            Article? result = await _articleRepository.GetAsync(x => x.Title == name, null, false, true, cancellationToken);
            ArticleGetDto mappedArticleGetDto = _mapper.Map<ArticleGetDto>(result);
            return CustomResponseDto<ArticleGetDto>.Success(statusCode: (int)HttpStatusCode.OK, data: mappedArticleGetDto, isSuccess: true);
        }

        public async Task<CustomResponseDto<IList<ArticleListDto>>> GetListAsync(CancellationToken cancellationToken = default)
        {
            IList<Article> result = await _articleRepository.GetListAsync(cancellationToken: cancellationToken);
            IList<ArticleListDto> mappedResult = _mapper.Map<IList<ArticleListDto>>(result);

            return CustomResponseDto<IList<ArticleListDto>>.Success(statusCode: (int)HttpStatusCode.OK, data: mappedResult, isSuccess: true);
        }

        public async Task<CustomResponseDto<GetListResponse<ArticleListDto>>> GetListPaginateAsync(PageRequest pageRequest, CancellationToken cancellationToken = default)
        {
            IPaginate<Article> result = await _articleRepository.GetListPaginateAsync(index: pageRequest.Index, size: pageRequest.Size, cancellationToken: cancellationToken);

            GetListResponse<ArticleListDto> mappedResult = _mapper.Map<GetListResponse<ArticleListDto>>(result);

            return CustomResponseDto<GetListResponse<ArticleListDto>>.Success(statusCode: (int)HttpStatusCode.OK, data: mappedResult, isSuccess: true);
        }

        public async Task<CustomResponseDto<ArticleGetDto>> DeleteAsync(ArticleDeleteDto articleDeleteDto, CancellationToken cancellationToken = default)
        {
            Article article = _mapper.Map<Article>(articleDeleteDto);
            Article deletedArticle = await _articleRepository.DeleteAsync(article);
            ArticleGetDto result = _mapper.Map<ArticleGetDto>(deletedArticle);
            return CustomResponseDto<ArticleGetDto>.Success(statusCode: (int)HttpStatusCode.OK, data: result,
                isSuccess: true);
        }

        public async Task<CustomResponseDto<ArticleGetDto>> UpdateAsync(ArticleUpdateDto articleUpdateDto)
        {
            Article article = _mapper.Map<Article>(articleUpdateDto);
            Article result = await _articleRepository.UpdateAsync(article);
            ArticleGetDto mappedResult = _mapper.Map<ArticleGetDto>(result);

            return CustomResponseDto<ArticleGetDto>.Success(statusCode: (int)HttpStatusCode.OK, data: mappedResult, isSuccess: true);

        }
    }
}
