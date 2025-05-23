using FluentValidation;
using Microsoft.Extensions.Localization;
using StakeMap.Core.Feautres.ApplicationUser.Commands.Models;
using StakeMap.Core.Shared;

namespace StakeMap.Core.Feautres.ApplicationUser.Commands.Vaildator
{
    public class CreateUserValidator : AbstractValidator<CreateUserCommands>
    {
        #region fields
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        #endregion
        #region Constructor
        public CreateUserValidator(IStringLocalizer<SharedResource> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }
        public CreateUserValidator()
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

            RuleFor(x => x.Password).
              NotEmpty().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]).
              NotNull().WithMessage(_stringLocalizer[SharedREsourceKeys.NotEmpty]);

        }

        public void ApplyCustomValidationRoles()
        {

        }
        #endregion
    }
}
