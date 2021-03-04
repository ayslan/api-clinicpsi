using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psi.API
{
    public class Config
    {
        static IConfiguration Configuration = Startup.StaticConfig;

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                // backward compat
                new ApiScope("api")
            };
        }

        public static IEnumerable<Client> Clients = new List<Client>
        {
            new Client
                {
                    ClientId = Configuration["AppConfiguration:ClientID"],
                    ClientName = "ClinicPsi SPA",
                    AllowedGrantTypes = new[] {GrantType.ResourceOwnerPassword,"external"},
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,
                    ClientSecrets = { new Secret(Configuration["AppConfiguration:ClientSecret"].Sha256()) },
                    AccessTokenLifetime = 3600,
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,
                    RefreshTokenExpiration = TokenExpiration.Absolute,
                    AllowOfflineAccess = true,
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OfflineAccess,
                        "api" },

                }
        };

        public static IEnumerable<IdentityResource> IdentityResources = new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
        };

        public static IEnumerable<ApiResource> Apis = new List<ApiResource>
        {
            // local API
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName),
        };
    }
}
