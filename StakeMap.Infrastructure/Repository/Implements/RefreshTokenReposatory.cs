using Microsoft.EntityFrameworkCore;
using StakeMap.Infrastructure.Base;
using StakeMap.Infrastructure.Context;
using StakeMap.Infrastructure.Entities.Identity;
using StakeMap.Infrastructure.Repository.Abstracts;

namespace StakeMap.Infrastructure.Repository.Implements
{
    public class RefreshTokenReposatory : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenReposatory
    {
        #region Fileds


        private DbSet<UserRefreshToken> _userTokens;
        #endregion
        #region Constructor

        public RefreshTokenReposatory(AppDbContext dbContext) : base(dbContext)
        {
            _userTokens = dbContext.Set<UserRefreshToken>();
        }
        #endregion
    }
}
