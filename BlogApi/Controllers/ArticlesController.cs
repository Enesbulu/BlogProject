using AutoMapper;
using BlogApi.Controllers.Base;
using BlogProject.Business.Abstracts;
using BlogProject.Business.Concretes;
using BlogProject.Business.Dtos.Article;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : BaseController
    {


        private readonly IArticleService _articleService;
        private readonly ArticleManager _articleManager;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        //private readonly IToastNotification _toastNotification;

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ArticleAddDto articleAddDto, CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            CustomResponseDto<IList<CategoryListDto>> categories = await _categoryService.GetListAsync(cancellationToken: cancellationToken);
            if (categories.IsSuccess)
            {
                //return Ok(new ArticleAddViewModel { Categories = categories.Data });
                return Ok(new { message = "Makale Ekleme işlemi başarılı.", success = true });
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetList(CancellationToken cancellationToken = default)
        {
            CustomResponseDto<IList<ArticleListDto>> result = await _articleService.GetListAsync(cancellationToken);
            if (result.Data is null) return BadRequest();
            Console.WriteLine($"Result değeri : {result}");
            return Ok(result);
        }
        //public async Task<IActionResult> GetById([FromRoute] Guid id)
        //{
        //    CustomResponseDto<GetByIdArticleResponse> response = await Mediator.Send(new GetByIdArticleQuery { Id = id });
        //    return Ok(response);
        //}
    }
}
