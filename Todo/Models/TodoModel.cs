using System.Diagnostics.Eventing.Reader;

namespace TodoAPI.API.Models
{
    public class TodoModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public TodoModel(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            IsCompleted = false;
        }


        public void setIsCompleted(bool completed)
        {
            IsCompleted = completed;
        }
    }
}
