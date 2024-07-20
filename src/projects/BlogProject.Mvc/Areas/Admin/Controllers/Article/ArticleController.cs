using AutoMapper;
using BlogProject.Business.Abstracts;
using BlogProject.Business.Dtos.Article;
using BlogProject.Business.Dtos.Articles;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.Mvc.Controllers.Base;
using BlogProject.Mvc.Models.Article;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BlogProject.Mvc.Areas.Admin.Controllers
{
    [Area("Admin/Article")]
    public class ArticleController : BaseController
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;


        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IToastNotification toastNotification)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
            _toastNotification = toastNotification;
        }

        /// <summary>
        /// Makaleler Tablosunun olduğu sayfayı Get Attribute ile çağırır.Makalelerin listelendiği sayfa açılır.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
        {
            CustomResponseDto<IList<ArticleListDto>> result = await _articleService.GetListAsync(cancellationToken);
            if (result.Data is null) return NotFound();

            return View(result);
        }

        /// <summary>
        /// Makale ekleme sayfasını Get Attiribute ile çağırır. Makale ekleme sayfasını açar.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("Article/Add")]
        public async Task<IActionResult> Add(CancellationToken cancellationToken = default)
        {
            CustomResponseDto<IList<CategoryListDto>> categories = await _categoryService.GetListAsync(cancellationToken: cancellationToken);
            if (categories.IsSuccess)
            {
                return View(new ArticleAddViewModel { Categories = categories.Data });
            }

            return NotFound();
        }


        /// <summary>
        /// Makale ekleme işlemi için Post Attribute kullanır. Hata yoksa anlık olarak ekler ve gösterir. Hata varsa validator ile hataları gösterir.
        /// </summary>
        /// <param name="articleAddViewModel"></param>
        /// <returns></returns>
        [HttpPost("Article/Add")]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {
            if (ModelState.IsValid)
            {
                ArticleAddDto articleAddDto = _mapper.Map<ArticleAddDto>(articleAddViewModel);
                CustomResponseDto<ArticleGetDto> result = await _articleService.AddAsync(articleAddDto);
                if (result.IsSuccess)
                {
                    _toastNotification.AddSuccessToastMessage("Makale başarıyla eklenmiştir", new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Articles");
                }
            }
            CustomResponseDto<IList<CategoryListDto>> categories = await _categoryService.GetListAsync();
            articleAddViewModel.Categories = categories.Data;
            return View(articleAddViewModel);
        }

        [HttpDelete("Articles/{articleId}")]
        public async Task<JsonResult?> Delete(Guid articleId)
        {
            CustomResponseDto<ArticleGetDto> article = await _articleService.GetByIdAsync(articleId);
            if (article.Data is not null)
            {
                ArticleDeleteDto articleDeleteDto = _mapper.Map<ArticleDeleteDto>(article.Data);
                CustomResponseDto<ArticleGetDto> result = await _articleService.DeleteAsync(articleDeleteDto);
                //JsonSerializer.Serialize(result);
                return Json(result);
            }

            return null;
        }



        //Todo: Makale güncelleme için servis yazılacak. Servis yazılırken Add metodu referans alınacak. Get işlemi ile ilgili idye sahip makale db den çekilecek ve ekranda dolu olarak gösterilecek. 

        ///// <summary>
        ///// Makale güncelleme işlemi için Post Attribute kullanır. Hata yoksa anlık olarak günceller ve gösterir. Hata varsa validator ile hataları gösterir.
        ///// </summary>
        ///// <param name="articleAddViewModel"></param>
        ///// <returns></returns>
        //[HttpPost("Update")]
        //public async Task<IActionResult> Update(Guid articleId,ArticleAddViewModel articleAddViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ArticleAddDto articleAddDto = _mapper.Map<ArticleAddDto>(articleAddViewModel);
        //        CustomResponseDto<ArticleGetDto> result = await _articleService.AddAsync(articleAddDto);
        //        if (result.IsSuccess)
        //        {
        //            _toastNotification.AddSuccessToastMessage("Makale başarıyla güncellenmiştir", new ToastrOptions
        //            {
        //                Title = "Başarılı İşlem!"
        //            });
        //            return RedirectToAction("Index", "Articles");
        //        }
        //    }
        //    CustomResponseDto<IList<CategoryListDto>> categories = await _categoryService.GetListAsync();
        //    articleAddViewModel.Categories = categories.Data;
        //    return View(articleAddViewModel);
        //}



    }
}
