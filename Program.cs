using rgInfra.Components;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using static rgInfra.ViewModel.Usuario.LoginApiViewModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddRazorComponents();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseRouting();
app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");
app.MapPost("/api/login", async (RequestLogin loginModel) =>
{
    if (loginModel.login == "cristiano@rgsystem.com.br" && loginModel.senha == "Cris1605@")
    {
        return Results.Ok(new ResponseLogin
        {
            accessToken = "dummyAccessToken",
            refreshToken = "dummyRefreshToken",
            description = "Login successful"
        });
    }
    return Results.Unauthorized();
});

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
