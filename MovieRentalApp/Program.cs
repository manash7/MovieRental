using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string cs = "name=ConnectionStrings:Connect";
builder.Services.AddDbContext<MovieRentalApp.Models.MovieRentalContext>(Options => Options.UseSqlServer(cs));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=MovieDashboard}/{id?}");

app.Run();
