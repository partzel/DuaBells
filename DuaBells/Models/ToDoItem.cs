using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuaBells.Models
{
    /// <summary>
    /// A basic data holder for the ToDo Items
    /// </summary>
    public class ToDoItem
    {
        public bool IsChecked { get; set; }
        public string? Content { get; set; }
    }
}
