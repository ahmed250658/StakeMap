using Microsoft.AspNetCore.Mvc;
using StakeMap.Api.Base;
using StakeMap.Core.AppMetaData;
using StakeMap.Core.Feautres.ApplicationUser.Commands.Models;
using StakeMap.Core.Feautres.Authentication.Commands.Models;


namespace Securiy_Authentication.Controllers
{
    [ApiController]
    public class AuthenticationController : AppBaseController
    {
        [HttpPost(Router.AppUserRouting.Create)]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommands command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpPost(Router.Authentication.LogIn)]
        public async Task<IActionResult> SignIn([FromForm] SignInCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

    }
}