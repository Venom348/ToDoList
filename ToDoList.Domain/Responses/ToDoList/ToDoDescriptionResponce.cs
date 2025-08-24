using ToDoList.Domain.Entities;
using ToDoList.Domain.Responses;
/// <summary>
///     Модель для вывода данных пользователю
/// </summary>
public class ToDoDescriptionResponce : ToDoResponce
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }
}