using AutoMapper;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Mvc.Models.Category;

namespace BlogProject.Mvc.AutoMapper.Profiles.Categories
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
