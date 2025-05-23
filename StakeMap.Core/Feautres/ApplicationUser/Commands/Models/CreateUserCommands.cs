using MediatR;
using StakeMap.Core.Bases;

namespace StakeMap.Core.Feautres.ApplicationUser.Commands.Models
{
    public class CreateUserCommands : IRequest<Response<string>>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
