using ToDoList.Domain.Entities;

namespace ToDoList.Domain.Requests.ToDoList;

/// <summary>
///     Модель отправки задачи на сервер
/// </summary>
public class PostToDoRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }
}