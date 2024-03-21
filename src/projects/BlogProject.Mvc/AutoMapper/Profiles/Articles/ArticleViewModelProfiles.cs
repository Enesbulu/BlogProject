using AutoMapper;
using BlogProject.Business.Dtos.Article;
using BlogProject.Business.Dtos.Articles;
using BlogProject.Mvc.Models.Article;

namespace BlogProject.Mvc.AutoMapper.Profiles.Articles
{
    public class ArticleViewModelProfiles : Profile
    {
        public ArticleViewModelProfiles()
        {
            CreateMap<ArticleAddDto, ArticleAddViewModel>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleUpdateViewModel>().ReverseMap();

        }
    }
}
