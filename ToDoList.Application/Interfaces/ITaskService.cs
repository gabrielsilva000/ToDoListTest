using ToDoList.Application.DTOs;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Interfaces
{
    public interface ITaskService
    {
        Task<List<TaskDTO>> GetAllTasks();
        Task<List<TaskDTO>> GetByStatus(bool status);
        Task<List<TaskDTO>> GetByPeriod(DateTime data);
        Task<TaskDTO> GetTaskById(int id);
        Task AddTask(TaskDTO taskDTO);
        Task UpdateTask(TaskDTO taskDTO);
        Task DeleteTask(int id);
    }
}
