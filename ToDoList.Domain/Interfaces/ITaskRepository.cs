using ToDoList.Domain.Entities;
namespace ToDoList.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAll();
        Task<List<TaskItem>> GetByStatus(bool status);
        Task<List<TaskItem>> GetByPeriod(DateTime data);
        Task<TaskItem> GetById(int id);
        Task Add(TaskItem taskItem);
        Task Update(TaskItem taskItem);
        Task Delete(int id);
    }
}
