using NapelemEditor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ElectronNET.API;
using NapelemEditor.Models;
using NapelemEditor.Interfaces;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using NapelemEditor.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//FONTOS!!
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<INapelem, NapelemController>();
builder.Services.AddScoped<IUser, UserController>();
// builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();


builder.Services.AddElectron();
builder.WebHost.UseElectron(args);
builder.Services.AddMudServices();
StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

CreateElectronWindow();

app.Run();


async void CreateElectronWindow()
{
    var window = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
        {
            Width = 1024,
            Height = 768,
        }

    );
    await window.WebContents.Session.ClearCacheAsync();
    
    //Alapértelmezett windows menü sort vágja le. 
    window.RemoveMenu();
}
