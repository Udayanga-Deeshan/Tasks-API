using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-IDTL75N;Database=MyTodoDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
                {
                    new Author { Id=1,FullName="Saman Perera"},
                    new Author { Id=2 ,FullName ="Joshuwa Desilva"},
                    new Author { Id=3 ,FullName ="Sasmitha Hiram"},
                    new Author { Id=4 ,FullName ="John Doe "}

                });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
               {
                Id = 1,
                Title = "Get boooks for school-DB",
                Description = "text books for the school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1

               },

                 new Todo
               {
                Id = 2,
                Title = "Plan Vacation",
                Description = "Book Tickets and  accomedation  for vacation",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New,
                AuthorId = 1

               },

                  new Todo
               {
                Id = 3,
                Title = "Update Software",
                Description = "Upgrade System Software to the latest version",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.New,
                AuthorId = 2

               },



            });
        }
    }
}
