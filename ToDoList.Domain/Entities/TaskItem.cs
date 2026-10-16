using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Entities
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime ExpirationDate { get; set; } = DateTime.Now.ToLocalTime();
    }
}
