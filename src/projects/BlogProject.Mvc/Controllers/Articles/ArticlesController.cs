using BlogProject.Businness.Abstracts;
using BlogProject.Businness.Dtos.Article;
using BlogProject.Core.Business.Concrete;
using BlogProject.Mvc.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Mvc.Controllers.Articles
{
    public class ArticlesController : BaseController
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken =default)
        {
            CustomResponseDto<IList<ArticleListDto>> result  = await _articleService.GetListAsync(cancellationToken);
            if (result?.Data is null) return NotFound();

            return View(result);
        }
    }
}
