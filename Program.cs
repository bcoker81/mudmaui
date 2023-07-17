using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AspNetCoreBlazorStateManagement.Data;
using AspNetCoreBlazorStateManagement.StateManagement;
using MudBlazor.Services;
using AspNetCoreBlazorStateManagement.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddMudServices();

// containerized in-memory state management
builder.Services.AddSingleton<StateContainer>();
builder.Services.AddSingleton<ReportContainer>();
builder.Services.AddSingleton<OverviewViewModel>();
builder.Services.AddSingleton<CreateEntityBusinessViewModel>();
builder.Services.AddSingleton<EntityViewModel>();
builder.Services.AddSingleton<VehicleViewModel>();
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

app.Run();
