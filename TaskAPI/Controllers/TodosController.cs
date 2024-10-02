using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodosController(ITodoRepository repository) {
            _todoService = repository;
        }
        [HttpGet("{id?}")]
        public IActionResult GetTodos(int ?id)
        {
            var mytodos = _todoService.AllTodos();
            if (id is null) return Ok(mytodos);
            mytodos = mytodos.Where(t=>t.Id ==id ).ToList();
            return Ok(mytodos);
        }

       
    }
}
