using Microsoft.AspNetCore.Identity;

namespace Core.Entities.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid> 
    {
        public int PersonName { get; set; }
    }
}
