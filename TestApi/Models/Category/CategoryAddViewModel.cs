using System.ComponentModel;

namespace TestApi.Models.Category
{
    public class CategoryAddViewModel
    {
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
