using System.Security.Claims;
using NapelemEditor.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Http.Extensions;
using MudBlazor;




namespace NapelemEditor.Authentication;

public class AuthStateProvider 
{
    // private readonly ProtectedSessionStorage _sessionStorage;
    // private ClaimsPrincipal _anonymous = new (new ClaimsIdentity());
    //
    // public AuthStateProvider(ProtectedSessionStorage sessionStorage)
    // {
    //     _sessionStorage = sessionStorage;
    // }
    // public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    // {
    //     try
    //     {
    //         var userSSResult = await _sessionStorage.GetAsync<Users>("UserSession");
    //         var userSession = userSSResult.Success ? userSSResult.Value : null;
    //         if (userSession is null)
    //             return await Task.FromResult(new AuthenticationState(_anonymous));
    //         var ClaimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
    //         {
    //             new(ClaimTypes.Name, userSession.UserName),
    //             new(ClaimTypes.Role, userSession.role)
    //         }, "auth"));
    //         return await Task.FromResult(new AuthenticationState(ClaimsPrincipal));
    //     }
    //     catch (Exception e)
    //     {
    //         return await Task.FromResult(new AuthenticationState(_anonymous));
    //     }
    //   
    // }
    //
    // public async Task UpdateAuthState(Users user)
    // {
    //     ClaimsPrincipal claimsPrincipal;
    //
    //     if (user is not null)
    //     {
    //         await _sessionStorage.SetAsync("UserSession", user);
    //         claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
    //         {
    //             new(ClaimTypes.Name, user.UserName),
    //             new(ClaimTypes.Role, user.role)
    //         } ));
    //     }
    //     else
    //     {
    //         await _sessionStorage.DeleteAsync("UserSession");
    //         claimsPrincipal = _anonymous;
    //         
    //     }
    //     NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
    // }
    
    
//     private async Task checkPermissionAsync(int minimum)
//     {
//         
//        
//             .ContainKeyAsync("Role"))
//         {
//             if (await localStorage.GetItemAsync<int>("Role") < minimum)
//             {
//                 Snackbar.Add("You have violated the law", Severity.Error);
//                 UriHelper.NavigateTo("/", forceLoad: true);
//             }
//         }
//         if (await sessionStorage.ContainKeyAsync("Role"))
//         {
//             if (await sessionStorage.GetItemAsync<int>("Role") < minimum)
//
//             {
//                 Snackbar.Add("You have violated the law", Severity.Error);
//                 UriHelper.NavigateTo("/", forceLoad: true);
//             }
//         }
//     }
}