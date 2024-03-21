using BlogProject.Mvc.Models.Category;
using FluentValidation;

namespace BlogProject.Mvc.Validations.CategoryValidators
{
    public class CategoryUpdateViewModelValidator : AbstractValidator<CategoryUpdateViewModel>
    {
        public CategoryUpdateViewModelValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori alanı boş geçilemez!");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("en az 3 karakter girilmelidir!");
            RuleFor(c => c.Name).MaximumLength(100).WithMessage("En fazla 100 karakter girilebilir!");

            RuleFor(c => c.Description).NotEmpty().WithMessage("Kategori Acıklaması boş geçilemez!");
            RuleFor(c => c.Description).MinimumLength(10).WithMessage("En az  10 karakter girilmelidir!");
            RuleFor(c => c.Description).MaximumLength(300).WithMessage("En fazla 300 karakter girilebilir!");
        }
    }
}
