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
builder.Services.AddAutoMapper(typeof(ArticleViewModelProfiles),typeof(CategoryViewModelProfiles)); //MVC katmaný için alternatif kullanýmý  services.AddAutoMapper(Assembly.GetExecutingAssembly());
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


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
#endregion
