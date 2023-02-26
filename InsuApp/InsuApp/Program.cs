using InsuApp1.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddResponseCaching();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o =>
{
    /*o.Cookie.Name = "AspNetCore.Identity.Application";
    o.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    o.Cookie.SameSite = SameSiteMode.Strict;
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
    o.SlidingExpiration = true;
    o.ExpireTimeSpan = TimeSpan.FromMinutes(1);
    o.LoginPath = new PathString("/Account/Login");
    o.LogoutPath = new PathString("/Account/Logout");
    o.AccessDeniedPath = new PathString("/Account/AccessDenied");*/
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "AspNetCore.Identity.Application";
    options.Cookie.SameSite = SameSiteMode.None;
    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
    options.SlidingExpiration = true;
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    options.LogoutPath = new PathString("/Account/Logout");
    options.AccessDeniedPath = new PathString("/Account/AccessDenied");

});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

//builder.Services.AddControllersWithViews();

/*builder.Services.AddControllersWithViews().AddRazorPagesOptions(options => {
    options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "");
});*/

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseResponseCaching();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*using (var scope = app.Services.CreateScope())
{
RoleManager<IdentityRole> roleManagement = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
UserManager<IdentityUser> userManagement = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

roleManagement.CreateAsync(new IdentityRole("admin")).Wait();
IdentityUser appUser = userManagement.FindByEmailAsync("admin2@admin.com").Result;
userManagement.AddToRoleAsync(appUser, "admin").Wait();
}*/

app.Run();
