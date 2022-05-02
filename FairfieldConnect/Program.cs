using Microsoft.EntityFrameworkCore;
using FairfieldConnect.Data;
using FairfieldConnect.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using FairfieldConnect.Services;
using FairfieldConnect;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FairfieldConnectContextConnection");

builder.Services.AddDbContext<FairfieldConnectContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<FairfieldConnectUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<FairfieldConnectContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//

builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);


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
    pattern: "{controller=Internal}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
