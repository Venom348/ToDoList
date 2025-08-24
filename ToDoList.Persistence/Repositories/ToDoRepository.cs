using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Abstractions.Repositories;
using ToDoList.Domain.Entities;

namespace ToDoList.Persistence.Repositories;

public class ToDoRepository : IBaseRepository<ToDoItem>
{
    private readonly ToDoListContext _dbContext;

    public ToDoRepository(ToDoListContext context)
    {
        _dbContext = context;
    }

    public IQueryable<ToDoItem> GetAll() => _dbContext.ToDoItems;

    public async Task<ToDoItem> GetById(int id) => await _dbContext.ToDoItems.FirstOrDefaultAsync(s => s.Id == id);

    public async Task<ToDoItem> Create(ToDoItem entity)
    {
        _dbContext.ToDoItems.Add(entity);
        await SaveChangesAsync();
        return entity;
    }

    public async Task<ToDoItem> Update(ToDoItem entity)
    {
        _dbContext.ToDoItems.Update(entity);
        await SaveChangesAsync();
        return entity;
    }

    public async Task<ToDoItem> Delete(ToDoItem entity)
    {
        _dbContext.ToDoItems.Remove(entity);
        await SaveChangesAsync();
        return entity;
    }
    
    public async Task<int> SaveChangesAsync( ) =>  await _dbContext.SaveChangesAsync();
}