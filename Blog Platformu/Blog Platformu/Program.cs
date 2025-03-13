using Microsoft.EntityFrameworkCore;
using 
 Blog_Platformu.Models ;
var builder = WebApplication.CreateBuilder(args);
// Sizin verdiğiniz kodlar buraya eklenecek
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDb")));

builder.Services.AddSession();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
