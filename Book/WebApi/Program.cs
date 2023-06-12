using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebApi;
using WebApi.Interface;
using WebApi.Models;
using WebApi.Repository;
using WebApi.Services;
using WebApi.Services.Interface;
using WebAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);
// register configuration
var configuration = builder.Configuration.Get<AppConfiguration>() ?? new AppConfiguration();
builder.Services.AddSingleton(configuration);
// dbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(configuration.ConnectionStrings.DatabaseConnection);
});
// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(MapperConfigurationsProfile));

builder.Services.AddSingleton<GlobalExceptionMiddleware>();
builder.Services.AddSingleton<PerformanceMiddleware>();
builder.Services.AddSingleton<Stopwatch>();
builder.Services.AddHealthChecks();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapHealthChecks("/hc");

app.UseAuthorization();

app.MapControllers();


app.Run();
