using RefBook.Infrastructure.Data;
using RefBook.Infrastructure.Repositories;
using RefBook.Application.Interfaces;
using RefBook.Application.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppData>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUsersRespository, UserRepository>();
builder.Services.AddScoped<IUsersService, usersService>();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
