using AutoMapper;
using BlogProject.Businness.Dtos.Article;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.DataAccess.Base.Paging;
using BlogProject.Entities.Concrete;

namespace BlogProject.Businness.Profiles.Articles
{
    public class ArticleMappingProfile: Profile
    {
        public ArticleMappingProfile()
        {
            CreateMap<Article, ArticleGetDto>().ReverseMap();
            CreateMap<Article, ArticleListDto>().ReverseMap();
            CreateMap<Article,ArticleAddDto>().ReverseMap();

            CreateMap<IPaginate<Article>,GetListResponse<ArticleListDto>>().ReverseMap();
        }
    }
}
