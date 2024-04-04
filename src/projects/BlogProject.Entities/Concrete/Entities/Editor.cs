using Microsoft.AspNetCore.Identity;

namespace BlogProject.Entities.Concrete.Entities
{
    public class Editor : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<Article> Article { get; set; }

        public Editor()
        {
            
        }
    }

}
