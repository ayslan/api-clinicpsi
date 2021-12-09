using System;
using System.ComponentModel;
using System.Security.Claims;
using System.Security.Principal;

namespace Psi.API.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserId(this IIdentity identity)
        {
            if (identity == null || !identity.IsAuthenticated)
            {
                throw new ArgumentNullException(nameof(identity));
            }

            var claim = new ClaimsPrincipal(identity);
            var loggedInUserId = claim.FindFirstValue("sub");
            var converter = TypeDescriptor.GetConverter(typeof(string));

            return (string)converter.ConvertFromInvariantString(loggedInUserId);
        }

        public static int GetCurrentTenantId(this IIdentity identity)
        {
            if (identity == null || !identity.IsAuthenticated)
            {
                throw new ArgumentNullException(nameof(identity));
            }

            var claim = new ClaimsPrincipal(identity);
            var currentTenantId = claim.FindFirstValue("current_tenant_id");
            var converter = TypeDescriptor.GetConverter(typeof(string));

            return (int)converter.ConvertFromInvariantString(currentTenantId);
        }
    }
}
