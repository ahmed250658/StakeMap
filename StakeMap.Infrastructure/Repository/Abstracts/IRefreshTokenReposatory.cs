using StakeMap.Infrastructure.Base;
using StakeMap.Infrastructure.Entities.Identity;

namespace StakeMap.Infrastructure.Repository.Abstracts
{
    public interface IRefreshTokenReposatory : IGenericRepositoryAsync<UserRefreshToken>
    {
    }
}
