using Microsoft.EntityFrameworkCore;
using WebDemo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(o =>
{
    o.UseInMemoryDatabase("MyDatabase");
});

var app = builder.Build();

app.MapControllers();

app.Run();