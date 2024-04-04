using Microsoft.AspNetCore.Identity;

namespace BlogProject.Entities.Concrete.Entities
{
    /// <summary>
    /// Yazar varlık yapsı oluşturulur.  BaseUserEntity ve IEntity<Guid> soyut yapılarından miras alır. Makaleler varlığı ile 1-n ilişkisi bulunur.
    /// </summary>
    public class Author : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<Article> Article { get; set; } = default!;

        public Author() { }
        
    }
}
