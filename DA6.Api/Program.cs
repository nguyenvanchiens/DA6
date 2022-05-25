
using DA6.Core.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.


var connnectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<DA6DbContext>(options =>
{
    options.UseMySql(connnectionString, Microsoft.EntityFrameworkCore.ServerVersion.AutoDetect(connnectionString));
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.Cookie.Name = "Authen";
    //options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    options.ExpireTimeSpan = new TimeSpan(0, 30, 0);
    options.Cookie.MaxAge = options.ExpireTimeSpan; // optional
    options.SlidingExpiration = true;
    options.AccessDeniedPath = "";
    options.LoginPath = "";
    options.LogoutPath = "";
});
var app = builder.Build();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
