using AutoMapper;
using BlogProject.Businness.Dtos.Categories;
using BlogProject.Entities.Concrete;

namespace BlogProject.Businness.Profiles.Categories
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();

        }
    }
}
