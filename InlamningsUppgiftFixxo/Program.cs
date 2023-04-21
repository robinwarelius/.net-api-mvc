using InlamningsUppgiftFixxo.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient(); // Add HTTP client service
builder.Services.AddHttpContextAccessor();


builder.Services.AddTransient<ProductService>();
builder.Services.AddTransient<ShowcaseService>();
builder.Services.AddTransient<ContactService>();
builder.Services.AddTransient<AccountService>();



var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();