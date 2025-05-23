using FluentValidation;
using Microsoft.Extensions.Localization;
using StakeMap.Core.Feautres.ContactSubmission.Commands.Model;
using StakeMap.Core.Shared;

namespace StakeMap.Core.Feautres.ContactSubmission.Commands.Validator
{
    public class CreateContactValidator : AbstractValidator<CreateContactCommand>
    {
        #region fields
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        #endregion
        #region Constructor
        public CreateContactValidator(IStringLocalizer<SharedResource> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }
        public CreateContactValidator()
        {
            ApplyValidationRoles();
            ApplyCustomValidationRoles();
        }

        #endregion
        #region Handle Function

        public void ApplyValidationRoles()
        {
            RuleFor(x => x.Name).
                NotEmpty().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]).
                NotNull().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]).
                MaximumLength(100).WithMessage(_stringLocalizer[SharedREsourceKeys.MaxLengthis100]);

            RuleFor(x => x.Email).
              NotEmpty().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]).
              NotNull().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]);


            RuleFor(x => x.Message).
              NotEmpty().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]).
              NotNull().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]);

        }

        public void ApplyCustomValidationRoles()
        {

        }
        #endregion
    }
}
