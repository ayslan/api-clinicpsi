using AutoMapper;
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
    public class AuthController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppConfiguration _appConfiguration;
        private readonly IMapper _mapper;

        public AuthController(IOptions<AppConfiguration> appConfiguration, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _appConfiguration = appConfiguration.Value;
            _mapper = mapper;
        }

        [HttpPost("login")]
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
