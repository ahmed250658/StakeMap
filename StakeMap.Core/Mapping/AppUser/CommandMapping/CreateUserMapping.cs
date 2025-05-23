using StakeMap.Core.Feautres.ApplicationUser.Commands.Models;
using StakeMap.Infrastructure.Entities.Identity;

namespace StakeMap.Core.Mapping.User
{
    public partial class UserProfile
    {
        public void AddUserMapping()
        {
            CreateMap<CreateUserCommands, Users>().
                 ForMember(d => d.UserName, s => s.MapFrom(src => src.Name)).
                 ForMember(d => d.Email, s => s.MapFrom(src => src.Email)).
                 ForMember(d => d.PasswordHash, s => s.MapFrom(src => src.Password));
        }
    }
}
