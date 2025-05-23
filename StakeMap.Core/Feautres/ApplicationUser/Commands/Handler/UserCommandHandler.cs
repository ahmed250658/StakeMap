using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using StakeMap.Core.Bases;
using StakeMap.Core.Feautres.ApplicationUser.Commands.Models;
using StakeMap.Core.Shared;

using StakeMap.Infrastructure.Entities.Identity;

namespace StakeMap.Core.Feautres.ApplicationUser.Commands.Handler
{
    public class UserCommandHandler : ResponseHandler,
                                          IRequestHandler<CreateUserCommands, Response<string>>

    {

        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        private readonly UserManager<Users> _userManager;
        #endregion
        #region Constructor
        public UserCommandHandler(IStringLocalizer<SharedResource> stringLocalizer, IMapper mapper, UserManager<Users> userManager) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _userManager = userManager;
        }
        #endregion
        #region Handle Function
        public async Task<Response<string>> Handle(CreateUserCommands request, CancellationToken cancellationToken)
        {
            //Check if Email is Exist
            var Existuser = await _userManager.FindByEmailAsync(request.Email);
            //Email is Exist
            if (Existuser != null) return NotFound<string>(_stringLocalizer[SharedREsourceKeys.EmailIsExist]);
            // Check if Email is Exist
            var ExistName = await _userManager.FindByNameAsync(request.Name);
            //Email is Exist
            if (ExistName != null) return NotFound<string>(_stringLocalizer[SharedREsourceKeys.UserNameIsExist]);
            //Create user
            var user = _mapper.Map<Users>(request);

            var result = await _userManager.CreateAsync(user, request.Password);
            //Failed
            if (!result.Succeeded) return BadRequest<string>(_stringLocalizer[SharedREsourceKeys.FaildAddUser]);
            //Add to Role
            await _userManager.AddToRoleAsync(user, "User");
            return Success("");
        }
        #endregion
    }
}
