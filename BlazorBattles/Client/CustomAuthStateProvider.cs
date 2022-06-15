using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorBattles.Client;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));

        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "Patrick")
        }, "test authentication type");

        var user = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(user));
    }
}