using BlogProject.Mvc.Models.Article;
using FluentValidation;

namespace BlogProject.Mvc.Validations.ArticleValidators
{
    public class ArticleAddViewModelValidator : AbstractValidator<ArticleAddViewModel>
    {
        public ArticleAddViewModelValidator()
        {
            //Title
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı bış bırakılamaz.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık Alanı minimum 5 karakter olmalıdır.");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Başlık alanı maksimum 100 karakter olmalıdır.");

            //Content
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik alanı bış bırakılamaz.");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Başlık Alanı minimum 20 karakter olmalıdır.");
            RuleFor(x => x.Content).MaximumLength(10000).WithMessage("Başlık alanı maksimum 10000 karakter olmalıdır.");

        }
    }
}
