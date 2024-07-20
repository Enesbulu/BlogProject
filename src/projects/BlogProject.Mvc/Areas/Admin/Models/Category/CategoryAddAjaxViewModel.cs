using BlogProject.Business.Dtos.Categories;

namespace BlogProject.Mvc.Models.Category
{
    public class CategoryAddAjaxViewModel
    {
        public CategoryUpdateViewModel CategoryUpdateViewModel { get; set; } = default!;
        public string CategoryAddPartial { get; set; } = string.Empty;
        public CategoryGetDto CategoryGetDto { get; set; } = default!;
    }
}
