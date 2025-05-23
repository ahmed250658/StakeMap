using AutoMapper;

namespace StakeMap.Core.Mapping.User
{
    public partial class UserProfile : Profile
    {
        public UserProfile()
        {
            AddUserMapping();

        }
    }
}
