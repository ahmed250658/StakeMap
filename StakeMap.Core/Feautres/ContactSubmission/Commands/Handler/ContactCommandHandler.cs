using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using StakeMap.Core.Bases;
using StakeMap.Core.Feautres.ContactSubmission.Commands.Model;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Core.Shared;
using StakeMap.Infrastructure.Entities;
using StakeMap.Infrastructure.Helper;
using StakeMap.Infrastructure.Repository.Abstracts;

namespace StakeMap.Core.Feautres.ContactSubmission.Commands.Handler
{
    public class ContactCommandHandler : ResponseHandler,
                                       IRequestHandler<CreateContactCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly EmailSettings _emailSettings;
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        private readonly IContactRepository _contactRepository;
        #endregion
        #region Constructor
        public ContactCommandHandler(IStringLocalizer<SharedResource> stringLocalizer, IMapper mapper, IContactRepository contactRepository, IEmailService emailService, EmailSettings emailSettings, IMediator mediator) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _contactRepository = contactRepository;
            _emailService = emailService;
            _emailSettings = emailSettings;
            _mediator = mediator;
        }
        #endregion
        #region Handle Function
        public async Task<Response<string>> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _emailService.SendEmail(request.Email, request.Name, request.Message);
            var contact = _mapper.Map<ContactSubmissions>(request);
            var result = await _contactRepository.AddAsync(contact);
            if (result == null)
                return BadRequest<string>(_stringLocalizer[SharedREsourceKeys.FaildAddContact]);

            return Success<string>(_stringLocalizer[SharedREsourceKeys.ContactSuccssfuly]);
        }
        #endregion
    }
}