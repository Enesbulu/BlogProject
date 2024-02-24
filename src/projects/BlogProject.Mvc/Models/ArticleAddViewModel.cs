using System.ComponentModel;
using BlogProject.Businness.Dtos.Categories;

namespace BlogProject.Mvc.Models
{
    public class ArticleAddViewModel
    {
        [DisplayName("Başlık")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("İçerik")]
        public string Content { get; set; } = string.Empty;
        
        [DisplayName("Küçük Resim")]
        public string Thumbnail { get; set; } = string.Empty;
        
        [DisplayName("Küçük Resim Ekle")]
        public IFormFile ThumbnailFile { get; set; } = default!;
        
        [DisplayName("Tarih")]
        public DateTime Date { get; set; }
        
        [DisplayName("Kategori")]
        public Guid CategoryId { get; set; }
        
        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }
        public IList<CategoryListDto> Categories { get; set; } = new List<CategoryListDto>();


    }
}
