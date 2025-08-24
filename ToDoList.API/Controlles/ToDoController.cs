using Microsoft.AspNetCore.Mvc;
using ToDoList.Core.Abstractions;
using ToDoList.Domain.Requests;
using ToDoList.Domain.Requests.ToDoList;

namespace ToDoList.API.Controlles;

[ApiController]
[Route("api/todolist")]
public class ToDoController : ControllerBase
{
    private readonly IToDoService _toDoService;

    public ToDoController(IToDoService toDoService)
    {
        _toDoService = toDoService;
    }
    
    /// <summary>
    ///     Создание задачи
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PostToDoRequest request)
    {
        var responce = await _toDoService.Create(request);
        return Ok(responce);
    }
    
    /// <summary>
    ///     Получение списка задач
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var responce = await _toDoService.Get(id);
            return Ok(responce);
        }
        catch (Exception ex)
        {
            return BadRequest("Неизвестная ошибка");
        }
        
    }
    
    /// <summary>
    ///     Обновление задачи
    /// </summary>
    [HttpPatch]
    public async Task<IActionResult> Update([FromBody] PatchToDoRequest request)
    {
        try
        {
            var responce = await _toDoService.Update(request);
            return Ok(responce);
        }
        catch (Exception ex)
        {
            return BadRequest("Неизвестная ошибка");
        }
    }
    
    /// <summary>
    ///     Удаление задачи
    /// </summary>
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var responce = await _toDoService.Delete(id);
            return Ok(responce);
        }
        catch (Exception ex)
        {
            return BadRequest("Неизвестная ошибка");
        }
    }
}