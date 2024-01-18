using BusinessAccessLayer;
using BusinessAccessLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<BookMovieTicketDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookMovieTickets;Integrated Security=True"));
});

builder.Services.AddTransient<RepositoryFactory>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IRepository<User>, UserRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwaggerUI();

app.UseSwagger();

app.MapControllers();

app.Run();
