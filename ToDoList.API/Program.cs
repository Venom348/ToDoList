using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Abstractions;
using ToDoList.Core.Abstractions.Repositories;
using ToDoList.Core.Implementations;
using ToDoList.Domain.Entities;
using ToDoList.Persistence;
using ToDoList.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IToDoService, ToDoService>();
builder.Services.AddDbContext<ToDoListContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("Psql")));
builder.Services.AddTransient<IBaseRepository<ToDoItem>, ToDoRepository>();
var app = builder.Build();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.Run();
