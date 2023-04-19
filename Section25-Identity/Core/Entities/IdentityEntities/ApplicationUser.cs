using Microsoft.AspNetCore.Identity;

namespace Core.Entities.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid> 
    {
        public string PersonName { get; set; }
    }
}
