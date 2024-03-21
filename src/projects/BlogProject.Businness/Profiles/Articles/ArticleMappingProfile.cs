using AutoMapper;
using BlogProject.Business.Dtos.Article;
using BlogProject.Business.Dtos.Articles;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.DataAccess.Base.Paging;
using BlogProject.Entities.Concrete;

namespace BlogProject.Business.Profiles.Articles
{
    public class ArticleMappingProfile : Profile
    {
        public ArticleMappingProfile()
        {
            CreateMap<Article, ArticleGetDto>().ReverseMap();
            CreateMap<Article, ArticleListDto>().ReverseMap();
            CreateMap<Article, ArticleAddDto>().ReverseMap();
            CreateMap<Article, ArticleDeleteDto>().ReverseMap();
            CreateMap<Article, ArticleUpdateDto>().ReverseMap();

            CreateMap<IPaginate<Article>, GetListResponse<ArticleListDto>>().ReverseMap();
            CreateMap<ArticleGetDto, ArticleDeleteDto>().ReverseMap();

        }
    }
}
