using AutoMapper;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.Core.DataAccess.Base.Paging;
using BlogProject.Entities.Concrete.Entities;

namespace BlogProject.Business.Profiles.Categories
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Category, CategoryGetDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            CreateMap<Category, CategoryDeleteDto>().ReverseMap();
            CreateMap<Category, CategoryAddDto>().ReverseMap();

            CreateMap<IPaginate<Category>, GetListResponse<CategoryListDto>>().ReverseMap();
            CreateMap<CategoryGetDto, CategoryDeleteDto>().ReverseMap();


        }
    }
}
