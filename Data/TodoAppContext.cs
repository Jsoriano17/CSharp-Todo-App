using System;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class TodoAppContext : DbContext
    {
        public TodoAppContext(DbContextOptions<TodoAppContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todo { get; set; }
    }
}