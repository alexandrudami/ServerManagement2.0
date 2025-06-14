using Microsoft.EntityFrameworkCore;
using ServerManagement2._0.Components;
using ServerManagement2._0.Data;
using ServerManagement2._0.Components.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContextFactory<ServerManagementContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SVManagement"));
}
);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



builder.Services.AddTransient<IServerEFCoreRepository, ServerEFCoreRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
