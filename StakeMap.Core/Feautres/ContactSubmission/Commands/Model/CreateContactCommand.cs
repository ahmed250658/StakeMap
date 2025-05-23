using MediatR;
using StakeMap.Core.Bases;

namespace StakeMap.Core.Feautres.ContactSubmission.Commands.Model
{
    public class CreateContactCommand : IRequest<Response<string>>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
