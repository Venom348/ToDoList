namespace ToDoList.Domain.Requests.ToDoList;
/// <summary>
///     Модель изменения задачи на сервере
/// </summary>
public class PatchToDoRequest : PostToDoRequest
{
    public int Id { get; set; }
}