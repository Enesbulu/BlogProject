using BlogProject.Businness.Dtos.Article;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.Entities.Dtos;

namespace BlogProject.Businness.Abstracts
{
    public interface IArticleService
    {
        Task<CustomResponseDto<ArticleGetDto>> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<CustomResponseDto<ArticleGetDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<CustomResponseDto<ArticleGetDto>> AddAsync(ArticleAddDto article, CancellationToken cancellationToken = default);
        Task<CustomResponseDto<IList<ArticleListDto>>> GetListAsync(CancellationToken cancellationToken = default);
        Task<CustomResponseDto<GetListResponse<ArticleListDto>>> GetListPaginateAsync(PageRequest pageRequest, CancellationToken cancellationToken = default);

    }
}
