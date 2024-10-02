using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get boooks for school",
                Description = "text books for the school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New


            };
            todos.Add(todo1);


            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Vegetables",
                Description = "get vegetables for this week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Inprogress


            };
            todos.Add(todo2);


            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Water the plants quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New


            };
            todos.Add(todo3);

            return todos;
        }
    }
}
