using ToDoList.Core.Abstractions;
using ToDoList.Core.Abstractions.Repositories;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Requests;
using ToDoList.Domain.Requests.ToDoList;
using ToDoList.Domain.Responses;

namespace ToDoList.Core.Implementations;

public class ToDoService : IToDoService
{
    private readonly IBaseRepository<ToDoItem> _toDoRepository;

    public ToDoService(IBaseRepository<ToDoItem> toDoRepository)
    {
        _toDoRepository = toDoRepository;
    }
    
    public async Task<ToDoDescriptionResponce> Create(PostToDoRequest request)
    {
        var result = await _toDoRepository.Create(new ToDoItem
        {
            Title = request.Title,
            Description = request.Description,
            IsComplete = request.IsComplete,
        });

        return new ToDoDescriptionResponce
        {
            Id = result.Id,
            Title = result.Title,
            Description = result.Description,
            IsComplete = result.IsComplete,
        };
    }
    
    public async Task<ToDoDescriptionResponce> Get(int id)
    {
        var result = await _toDoRepository.GetById(id);
        
        if (result is null)
        {
            throw new Exception("Задача не найдена");
        }

        return new ToDoDescriptionResponce
        {
            Id = result.Id,
            Title = result.Title,
            Description = result.Description,
            IsComplete = result.IsComplete
        };
    }

    public async Task<ToDoDescriptionResponce> Update(PatchToDoRequest request)
    {
        var result = await _toDoRepository.GetById(request.Id);

        if (result is null)
        {
            throw new Exception("Задача не найдена");
        }

        result.Title = request.Title;
        result.Description = request.Description;
        result.IsComplete = request.IsComplete;
        
        result = await _toDoRepository.Update(result);
        
        return new ToDoDescriptionResponce
        {
            Id = result.Id,
            Title = result.Title,
            Description = result.Description,
            IsComplete = result.IsComplete
        };
    }

    public async Task<ToDoResponce> Delete(int id)
    {
        var result = await _toDoRepository.GetById(id);
        
        if (result is null)
        {
            throw new Exception("Задача не найдена");
        }
        
        result = await _toDoRepository.Delete(result);

        return new ToDoDescriptionResponce
        {
            Id = result.Id,
            Title = result.Title,
            Description = result.Description,
            IsComplete = result.IsComplete
        };
    }
}