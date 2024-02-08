using AutoMapper;
using BlogProject.Businness.Abstracts;
using BlogProject.Businness.Dtos.Article;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.DataAccess.Base.Paging;
using BlogProject.Core.Entities.Dtos;
using BlogProject.DataAccess.EntityFramework.Repositories.Abstracts;
using BlogProject.Entities.Concrete;
using System.Net;

namespace BlogProject.Businness.Concretes
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
            Article? result = await _articleRepository.GetAsync(x => x.Id == id, null, false, false, cancellationToken);
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


    }
}
