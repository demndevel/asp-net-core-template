using Microsoft.EntityFrameworkCore;
using Template.Application;
using Template.Application.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddDbContext<AppDbContext>(builder =>
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