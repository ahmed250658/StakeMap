using AutoMapper;

namespace StakeMap.Core.Mapping.Contact
{
    public partial class ContactProfile : Profile
    {
        public ContactProfile()
        {
            ContactCommandMapping();
        }
    }
}
