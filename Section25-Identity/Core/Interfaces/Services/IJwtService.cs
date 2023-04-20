using Core.DTOs;
using Core.Entities.IdentityEntities;

namespace Core.Interfaces.Services
{
    public interface IJwtService
    {
        AuthenticationResponse CreateJwt(ApplicationUser applicationUser);
    }
}
