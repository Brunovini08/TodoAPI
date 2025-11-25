using Microsoft.EntityFrameworkCore;
using TodoAPI.API.Models;

namespace Todo.API.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<TodoModel> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlite("Data Source=todo.db");
        }
    }
}
