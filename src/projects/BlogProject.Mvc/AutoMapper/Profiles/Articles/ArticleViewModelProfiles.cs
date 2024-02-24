using AutoMapper;
using BlogProject.Businness.Dtos.Article;
using BlogProject.Mvc.Models;

namespace BlogProject.Mvc.AutoMapper.Profiles.Articles
{
    public class ArticleViewModelProfiles : Profile
    {
        public ArticleViewModelProfiles()
        {
            CreateMap<ArticleAddDto, ArticleAddViewModel>().ReverseMap();
        }
    }
}
