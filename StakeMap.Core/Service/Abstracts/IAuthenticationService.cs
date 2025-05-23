using System.IdentityModel.Tokens.Jwt;
using StakeMap.Infrastructure.Entities.Identity;
using StakeMap.Infrastructure.Helper;
namespace StakeMap.Core.Service.Abstracts
{
    public interface IAuthenticationService
    {
        public Task<JwtAuthResult> GetJWTToken(Users user);
        //public JwtSecurityToken ReadJwtToken(string accessToken);
        public Task<(string, DateTime?)> ValidateDetails(JwtSecurityToken jwtToken, string AccessToken, string RefreshToken);
        public Task<JwtAuthResult> GetRefreshToken(Users user, JwtSecurityToken jwtToken, DateTime? expiryDate, string refreshToken);

    }
}
