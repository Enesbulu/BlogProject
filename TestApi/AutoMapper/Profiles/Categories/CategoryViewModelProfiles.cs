using AutoMapper;
using BlogProject.Business.Dtos.Categories;
using TestApi.Models.Category;

namespace TestApi.AutoMapper.Profiles.Categories
{
    public class CategoryViewModelProfiles:Profile
    {
        public CategoryViewModelProfiles()
        {
            CreateMap<CategoryGetDto, CategoryUpdateViewModel>().ReverseMap();
            CreateMap<CategoryUpdateDto, CategoryUpdateViewModel>().ReverseMap();
            CreateMap<CategoryAddDto, CategoryAddViewModel>().ReverseMap();
        }
    }
}
