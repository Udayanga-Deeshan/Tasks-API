using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository, IMapper mapper) {
            _todoService = repository;
            _mapper = mapper;
        }
        [HttpGet("{id?}")]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)
        {
            var mytodos = _todoService.AllTodos( authorId);

            var mappedTodos = _mapper.Map<ICollection<TodoDto>>(mytodos);
            return Ok(mappedTodos);
        }

       
    }
}
