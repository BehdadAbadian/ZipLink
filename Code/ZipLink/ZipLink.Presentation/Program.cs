using Microsoft.AspNetCore.HttpsPolicy;
using ZipLink.Application;
using ZipLink.Infrastructure;
using ZipLink.Infrastructure.Database;
using ZipLink.Presentation.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ReDirectMiddleware>();

builder.Services.AddInfrastructureSetup();
builder.Services.AddDatabaseSetup(builder.Configuration);
builder.Services.AddServiceSetup();

var app = builder.Build();

app.UseMiddleware<ReDirectMiddleware>();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
