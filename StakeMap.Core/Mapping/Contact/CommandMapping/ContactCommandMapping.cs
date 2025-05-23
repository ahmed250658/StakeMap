using StakeMap.Core.Feautres.ContactSubmission.Commands.Model;
using StakeMap.Infrastructure.Entities;

namespace StakeMap.Core.Mapping.Contact
{
    public partial class ContactProfile
    {
        public void ContactCommandMapping()
        {
            CreateMap<CreateContactCommand, ContactSubmissions>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message));
        }
    }
}
