using Microsoft.AspNetCore.Identity;

namespace BlogProject.Entities.Concrete.AuthEntities
{
    public class User : IdentityUser<Guid>
    {
        public string? Description { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;

    }
}
