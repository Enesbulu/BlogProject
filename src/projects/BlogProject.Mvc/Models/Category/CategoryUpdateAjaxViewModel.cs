using BlogProject.Business.Dtos.Categories;

namespace BlogProject.Mvc.Models.Category
{
    /// <summary>
    /// View Modal dan alnına verileri tutmak için oluşturulmuş model yapısı. Ajax yazımında kullanılacak.
    /// </summary>
    public class CategoryUpdateAjaxViewModel
    {
        public CategoryUpdateViewModel CategoryUpdateViewModel { get; set; } = default!;
        public string CategoryUpdatePartial { get; set; } = string.Empty;
        public CategoryGetDto CategoryGetDto { get; set; } = default!;
    }
}
