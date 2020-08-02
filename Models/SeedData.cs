using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Data;
using System.Linq;

namespace TodoApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var Context = new TodoAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<TodoAppContext>>()))
            {
                if (Context.Todo.Any())
                {
                    return;
                }
                Context.Todo.AddRange(
                    new Todo
                    {
                        Task = "feed the dogs",
                        StartDate = DateTime.Parse("2020-4-12"),
                        IsComplete = true
                    },
                    new Todo
                    {
                        Task = "go eat",
                        StartDate = DateTime.Parse("2020-5-12"),
                        IsComplete = false
                    },
                    new Todo
                    {
                        Task = "poop outside",
                        StartDate = DateTime.Parse("2020-6-12"),
                        IsComplete = true
                    },
                    new Todo
                    {
                        Task = "cum outside",
                        StartDate = DateTime.Parse("2020-7-12"),
                        IsComplete = false
                    }
                    ) ;
                Context.SaveChanges();
            }
        }
    }
}
