using System.Security.Claims;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;

namespace Vladify.BusinessLogic.Extensions;

public static class JwtClaimsExtensions
{
    public static string GetEmail(this ClaimsPrincipal principal)
    {
        var userExternalId = principal.FindFirst(BusinessLogicLayerConstants.CustomEmailClaimName)?.Value
            ?? throw new UnauthorizedException("unable to get user externalId");

        return userExternalId;
    }
}
