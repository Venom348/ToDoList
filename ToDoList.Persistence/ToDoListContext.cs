using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;

namespace ToDoList.Persistence;
/// <summary>
///     Модель для подключения БД (PostgreSQL)
/// </summary>
public class ToDoListContext : DbContext
{
    public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();

    public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options)
    {
        if (Database.EnsureCreated())
        {
            Init();
        }
    }

    private void Init()
    {
        SaveChanges();
    }
}