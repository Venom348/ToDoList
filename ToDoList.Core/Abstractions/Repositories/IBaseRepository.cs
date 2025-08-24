using ToDoList.Domain.Entities;

namespace ToDoList.Core.Abstractions.Repositories;
/// <summary>
///     Базовый интерфейс для взаимодействия с сущностями в базе
/// </summary>
public interface IBaseRepository<TEntity> where TEntity : ToDoItem
{
    /// <summary>
    ///     Получаем запрос для сущности
    /// </summary>
    IQueryable<TEntity> GetAll();
    
    /// <summary>
    ///     Получаем сущность по ID
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns></returns>
    Task<TEntity?> GetById(int id);
    
    /// <summary>
    ///     Создаём новую сущность
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    Task<TEntity> Create(TEntity entity);
    
    /// <summary>
    ///     Обновляем сущность
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    Task<TEntity> Update(TEntity entity);
    
    /// <summary>
    ///     Удаляем сущность
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    Task<TEntity> Delete(TEntity entity);
}