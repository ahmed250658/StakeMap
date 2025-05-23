using Microsoft.EntityFrameworkCore;
using StakeMap.Infrastructure.Base;
using StakeMap.Infrastructure.Context;
using StakeMap.Infrastructure.Entities;
using StakeMap.Infrastructure.Repository.Abstracts;

namespace StakeMap.Infrastructure.Repository.Implements
{
    public class ContactRepository : GenericRepositoryAsync<ContactSubmissions>, IContactRepository

    {
        #region Fileds


        private DbSet<ContactSubmissions> _contact;
        #endregion
        #region Constructor

        public ContactRepository(AppDbContext dbContext) : base(dbContext)
        {
            _contact = dbContext.Set<ContactSubmissions>();
        }
        #endregion
    }
}
