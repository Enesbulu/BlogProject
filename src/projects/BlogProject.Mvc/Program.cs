using Autofac;
using Autofac.Extensions.DependencyInjection;
using BlogProject.Business;
using BlogProject.Core.CrossCuttingConcerns.Exceptions.Extensions;
using BlogProject.DataAccess;
using BlogProject.DataAccess.EntityFramework.Modules;
using BlogProject.Mvc.AutoMapper.Profiles.Articles;
using BlogProject.Mvc.AutoMapper.Profiles.Categories;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


#region Services

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Program>()).AddNToastNotifyToastr();//program içerisindeki bütün validation classlarýný otomatik tanýmlar.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDataAccessServices(builder.Configuration);  //Data Access katmaný extensions
builder.Services.AddBussinessServices();    //Business katmaný extensions   
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepositoryModule()));
builder.Services.AddAutoMapper(typeof(ArticleViewModelProfiles), typeof(CategoryViewModelProfiles)); //MVC katmaný için alternatif kullanýmý  services.AddAutoMapper(Assembly.GetExecutingAssembly());
#endregion


#region Middlewares

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

app.UseAuthorization();
app.UseNToastNotify();
app.ConfigureExceptionMiddleware();


#region app.UseEndpoints

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "admin",
//        pattern: "admin/{controller=Admin}/{action=Index}/{id?}");
//    endpoints.MapControllerRoute(
//        name: "user",
//        pattern: "user/{controller=User}/{action=Index}/{id?}");
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});

//app.MapControllerRoute(
//    name: "areas",
//    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{area=User}/{controller=User}/{action=Index}/{id?}");
//app.MapControllerRoute(
//    name: "defaultRoute",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "Admin",
//        pattern: "Admin/{controller=Home}/{action=Index}/{id?}",
//        defaults: new { area = "Admin" });

//    endpoints.MapControllerRoute(
//        name: "User",
//        pattern: "User/{controller=Home}/{action=Index}/{id?}",
//        defaults: new { area = "User" });

//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{area=Blog}/{controller=Home}/{action=Index}/{id?}");
//});


//app.MapControllerRoute(
//    name: "admin",
//    pattern: "admin/{controller=Admin}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "user",
//    pattern: "user/{controller=User}/{action=Index}/{id?}");
#endregion

#region app.MapControllerRoute

//app.MapControllerRoute(
//        name: "User",
//pattern: "{controller=User}/{action=Index}"));
#endregion

/*app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
*/



//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "admin",
//        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
//    //endpoints.MapControllerRoute(
//    //    name: "default",
//    //    pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "defaultRoute",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
#endregion
