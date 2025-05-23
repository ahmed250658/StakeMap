using Microsoft.AspNetCore.Mvc;
using StakeMap.Api.Base;
using StakeMap.Core.AppMetaData;
using StakeMap.Core.Feautres.ContactSubmission.Commands.Model;

namespace StakeMap.Api.Controllers
{
    [ApiController]
    public class ContactController : AppBaseController
    {
        [HttpPost(Router.Contact.CreateContact)]
        public async Task<IActionResult> CreateContact([FromBody] CreateContactCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
    }
}
