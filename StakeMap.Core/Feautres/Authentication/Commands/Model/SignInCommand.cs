using MediatR;
using StakeMap.Core.Bases;
using StakeMap.Infrastructure.Helper;

namespace StakeMap.Core.Feautres.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
