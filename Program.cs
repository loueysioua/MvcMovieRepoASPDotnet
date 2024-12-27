using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovieRepo.Data;
using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories;
using MvcMovieRepo.Repositories.interfaces;
using mvcMovieRepositoryDotnet.Services.ServiceContracts;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MvcMovieRepoContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcMovieRepoContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieRepoContext' not found.")));


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IMembershipTypeRepository, MembershipTypeRepository>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IMembershipTypeService, MembershipTypeService>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
