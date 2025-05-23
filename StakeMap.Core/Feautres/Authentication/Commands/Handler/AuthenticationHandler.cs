using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using StakeMap.Core.Bases;
using StakeMap.Core.Feautres.Authentication.Commands.Models;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Core.Shared;
using StakeMap.Infrastructure.Entities.Identity;
using StakeMap.Infrastructure.Helper;


namespace Wasted_Food.Core.Feautres.Authentication.Commands.Handler
{
    public class AuthenticationHandler : ResponseHandler,
                                        IRequestHandler<SignInCommand, Response<JwtAuthResult>>


    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;
        private readonly IAuthenticationService _authenticationService;
        #endregion
        #region Constructor
        public AuthenticationHandler(IStringLocalizer<SharedResource> stringLocalizer, IMapper mapper, UserManager<Users> userManager, SignInManager<Users> signInManager, IAuthenticationService authenticationService) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _authenticationService = authenticationService;
        }
        #endregion
        #region Handle Function
        public async Task<Response<JwtAuthResult>> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            ///check if user is Exist or Not
            var user = await _userManager.FindByEmailAsync(request.Email);
            //Return User Not Found
            if (user == null) return NotFound<JwtAuthResult>(_stringLocalizer[SharedREsourceKeys.EmailIsNotFound]);
            //Sign in
            var signin = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            //Failed Signin
            if (!signin.Succeeded)
                return BadRequest<JwtAuthResult>(_stringLocalizer[SharedREsourceKeys.PasswordNotCorrect]);
            //Generate Token
            var result = await _authenticationService.GetJWTToken(user);
            //Return token
            return Success(result);
        }


        #endregion
    }
}
