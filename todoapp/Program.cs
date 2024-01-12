using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using todoapp.Data;

string credentialPath = @"D:\MyNotes\MyProject\Test-with-Firebase\auth-demo-a3895-firebase-adminsdk-ounac-37523dae75.json";
Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialPath);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
