using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FairfieldConnect.Data;
using FairfieldConnect.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FairfieldConnectContextConnection");
builder.Services.AddDbContext<FairfieldConnectContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<FairfieldConnectUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<FairfieldConnectContext>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
