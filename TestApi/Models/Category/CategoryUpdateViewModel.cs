 using System.ComponentModel;

 namespace TestApi.Models.Category
{
    public class CategoryUpdateViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Kategorti Adı")]
        public required string Name { get; set; }

        [DisplayName("Açıklama")]
        public required string Description { get; set; }

        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
