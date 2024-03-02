using AutoMapper;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Entities.Concrete;

namespace BlogProject.Business.Profiles.Categories
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Category, CategoryGetDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();

        }
    }
}
