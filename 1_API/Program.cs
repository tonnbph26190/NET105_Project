using Data.DbContexts;
using Data.IRepositories;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IAllRepositories<>), typeof(AllRepositories<>));
builder.Services.AddDbContext<CuaHangDbContext>(c => c.UseSqlServer(@"Data Source=DESKTOP-OJ4UDNH\SQLEXPRESS;Initial Catalog=Fake;Persist Security Info=True;User ID=Nbton03;Password=123"));

var app = builder.Build();

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
