using System;
using System.ComponentModel.DataAnnotations;
namespace TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public bool IsComplete { get; set; }
        public Todo()
        {
        }
    }
}
