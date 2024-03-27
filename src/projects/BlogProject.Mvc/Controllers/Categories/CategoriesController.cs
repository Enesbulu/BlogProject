using AutoMapper;
using BlogProject.Business.Abstracts;
using BlogProject.Business.Dtos.Categories;
using BlogProject.Core.Business.Concrete;
using BlogProject.Mvc.Controllers.Base;
using BlogProject.Mvc.Controllers.Extensions;
using BlogProject.Mvc.Models;
using BlogProject.Mvc.Models.Article;
using BlogProject.Mvc.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify.Helpers;

namespace BlogProject.Mvc.Controllers.Categories
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        /// <summary>
        /// Kategori sayfasını açan ve listeleyen metod
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("Categories/Index")]
        public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
        {
            CustomResponseDto<IList<CategoryListDto>> result = await _categoryService.GetListAsync(cancellationToken);
            if (result.Data is null) return NotFound();

            return View(result);

        }


        /// <summary>
        /// Kategori güncelleme ekranını açan metod.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet("Categories/Update")]
        public async Task<IActionResult> Update(Guid categoryId, CancellationToken cancellationToken = default)
        {
            CustomResponseDto<CategoryGetDto> category = await _categoryService.GetByIdAsync(categoryId, cancellationToken);
            if (category.IsSuccess)
            {
                CategoryUpdateViewModel categoryViewModel = _mapper.Map<CategoryUpdateViewModel>(category.Data);
                return PartialView("_CategoryUpdatePartial", categoryViewModel);
            }

            return NotFound();
        }


        /// <summary>
        /// Modal'dan alınan verilerle PUT işlemi gerçekleştirir.
        /// </summary>
        /// <param name="categoryUpdateViewModel"></param>
        /// <returns></returns>
        [HttpPost("Categories/Update")]  //put olarak ayarlanması daha doğru olacak ilerleyen aşamada burayı post olarak ve categoryIndex.js dosyasında da Ajax func tarafını da put/Ajax olarak değiştirmek gerekiyor.
        public async Task<IActionResult> Update(CategoryUpdateViewModel categoryUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                CategoryUpdateDto categoryUpdateDto = _mapper.Map<CategoryUpdateDto>(categoryUpdateViewModel);
                CustomResponseDto<CategoryGetDto> result = await _categoryService.UpdateAsync(categoryUpdateDto);
                if (result.IsSuccess)
                {
                    string categoryUpdateAjaxModel = System.Text.Json.JsonSerializer.Serialize( new CategoryUpdateAjaxViewModel
                    {
                        CategoryGetDto = result.Data,
                        CategoryUpdatePartial = await this.RenderViewToStringAsync("_CategoryUpdatePartial",model: categoryUpdateViewModel)
                    }); //JsonSerializer.Serialize
                    return Json(categoryUpdateAjaxModel);
                }
            }
            return NotFound();
        }

        //[HttpGet("Categories/Add")]
        //public async Task<IActionResult> Add(CancellationToken cancellationToken = default)
        //{
        //    CustomResponseDto<IList<CategoryListDto>> categories = await _categoryService.GetListAsync(cancellationToken);
        //    if (categories.IsSuccess)
        //    {
        //        return View(categories.Data);
        //    }

        //    return NotFound();
        //}
    }
}
