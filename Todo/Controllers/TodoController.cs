using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using Todo.API.Data;
using TodoAPI.API.Models;

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        private AppDbContext _context = new AppDbContext();

        [HttpGet]
        public ActionResult<List<TodoModel>> GetAll()
        {
            var todos = _context.Todos.ToList();

            if (todos is null || !todos.Any())
                return NotFound("Nenhuma tarefa encontrada!");

            return Ok(todos);
        }

        [HttpPost]
        public ActionResult<TodoModel> AddTodo([FromBody] TodoModel todo)
        {
            var newTodo = new TodoModel(todo.Title);
            _context.Add(newTodo);
            _context.SaveChanges();
            return Ok(todo);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoModel> GetTodoById(string id)
        {
            var todo = _context.Todos.Find(new Guid(id));

            if (todo is null)
                return NotFound("Não tarefa encontrada!");
            else
                return Ok(todo);
        }

        [HttpPatch("{id}")]
        public ActionResult FinishTodo(string id)
        {
            var todo = _context.Todos.Find(new Guid(id));

            if (todo is null)
                return NotFound("Não tarefa encontrada!");
            else
            {
                _context.Attach(todo);
                todo.setIsCompleted(true);
                _context.Entry(todo).Property(t => t.IsCompleted).IsModified = true;
                _context.SaveChanges();
                return Ok(todo);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTodo(string id)
        {
            var todo = _context.Todos.Find(new Guid(id));
            if (todo is null)
                return NotFound("Não tarefa encontrada!");
            else
            {
                _context.Remove(todo);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
