using AutoMapper;
using BlogProject.Businness.Abstracts;
using BlogProject.Businness.Dtos.Article;
using BlogProject.Businness.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.Mvc.Controllers.Base;
using BlogProject.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BlogProject.Mvc.Controllers.Articles
{
    public class ArticlesController : BaseController
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;


        public ArticlesController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IToastNotification toastNotification)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
        {
            CustomResponseDto<IList<ArticleListDto>> result = await _articleService.GetListAsync(cancellationToken);
            if (result.Data is null) return NotFound();

            return View(result);
        }


        [HttpGet("Add")]
        public async Task<IActionResult> Add(CancellationToken cancellationToken = default)
        {
            CustomResponseDto<IList<CategoryListDto>> categories = await _categoryService.GetListAsync(cancellationToken: cancellationToken);
            if (categories.IsSuccess)
            {
                return View(new ArticleAddViewModel { Categories = categories.Data });
            }

            return NotFound();
        }



        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {
            if (ModelState.IsValid)
            {
                ArticleAddDto articleAddDto = _mapper.Map<ArticleAddDto>(articleAddViewModel);
                CustomResponseDto<ArticleGetDto> result = await _articleService.AddAsync(articleAddDto);

                if (result.IsSuccess)
                {
                    _toastNotification.AddSuccessToastMessage("Makale başarıyla eklenmiştir.", new ToastrOptions { Title = "Başarılı işlem!" });
                    return RedirectToAction("Index","Articles");    //??
                }
            }
            CustomResponseDto<IList<CategoryListDto>> categories = await _categoryService.GetListAsync();
            articleAddViewModel.Categories = categories.Data;
            return View(articleAddViewModel);

        }
    }
}
