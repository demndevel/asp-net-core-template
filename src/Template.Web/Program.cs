using Microsoft.EntityFrameworkCore;
using Template.Application;
using Template.Application.Interfaces;
using Template.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddDbContext<IAppDbContext, AppDbContext>(builder =>
{
    builder.UseSqlite(connectionString: ""); // TODO
});
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();