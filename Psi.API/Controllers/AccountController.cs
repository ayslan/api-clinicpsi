using AutoMapper;
using IdentityServer4;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Psi.API.Base;
using Psi.API.Data;
using Psi.Domain.Entities;
using Psi.Domain.Models.User;
using Psi.Infra.CrossCutting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Psi.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AccountController : BaseController
    {
        private readonly AppConfiguration _appConfiguration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<ApplicationUser> userManager, IMapper mapper, IOptions<AppConfiguration> appConfiguration)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appConfiguration = appConfiguration.Value;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return Response();
            }

            var user = new ApplicationUser
            {
                Name = model.Name,
                Email = model.Email,
                UserName = model.Email,
                LockoutEnabled = false,
            };

            try
            {
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return OkResponse(_mapper.Map<ApplicationUserModel>(user));
                }

                return Response(result.Errors.ToDictionary(x => x.Code, x => x.Description));
            }
            catch
            {
                return Response();
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var body = new Dictionary<string, string>
            {
                {"grant_type", "password" },
                {"username", model.Email },
                {"password", model.Password },
                {"client_id", _appConfiguration.ClientID },
                {"client_secret", _appConfiguration.ClientSecret },
                {"scope", _appConfiguration.Scope }
            };

            var urlLogin = _appConfiguration.BaseURL + "/connect/token";
            var parsedBody = UtilRest.CreateFormBody(body);
            var result = UtilRest.RequestClient(Method.POST, urlLogin, parsedBody, "application/x-www-form-urlencoded");

            if (result.StatusCode == HttpStatusCode.OK)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var userModel = _mapper.Map<ApplicationUserModel>(user);

                return OkResponse(result.Content, userModel);
            }
            else
            {
                ModelState.AddModelError("LOGINERROR", "Email e/ou Senha incorretos!");
                return Response();
            }
        }
    }
}
