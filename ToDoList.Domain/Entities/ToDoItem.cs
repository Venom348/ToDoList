namespace ToDoList.Domain.Entities;
/// <summary>
///     Сущность задачи
/// </summary>
public class ToDoItem
{
    /// <summary>
    ///     Идентификатор задачи
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Название задачи
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    ///     Описание задачи
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    ///     Ссылка на подзадачу
    /// </summary>
    public ToDoItem? SubTask { get; set; }
    
    /// <summary>
    ///     Выполнена ли задача
    /// </summary>
    public bool IsComplete { get; set; }
}