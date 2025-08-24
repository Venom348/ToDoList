using ToDoList.Domain.Requests;
using ToDoList.Domain.Requests.ToDoList;
using ToDoList.Domain.Responses;

namespace ToDoList.Core.Abstractions;
/// <summary>
///     Сервис для работы с задачами
/// </summary>
public interface IToDoService
{
    /// <summary>
    ///     Создание задачи
    /// </summary>
    /// <param name="request">Данные о создании задачи</param>
    /// <returns></returns>
    Task<ToDoDescriptionResponce> Create(PostToDoRequest request);
    
    /// <summary>
    ///     Получение задач из БД
    /// </summary>
    /// <returns></returns>
    Task<ToDoDescriptionResponce> Get(int id);
    
    /// <summary>
    ///     Обновление задачи
    /// </summary>
    /// <param name="request">Данные об обновлении задачи</param>
    /// <returns></returns>
    Task<ToDoDescriptionResponce> Update(PatchToDoRequest request);
    
    /// <summary>
    ///     Удаление задачи
    /// </summary>
    Task<ToDoResponce> Delete(int id);
}