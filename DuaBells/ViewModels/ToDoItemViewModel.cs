using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using DuaBells.Models;

namespace DuaBells.ViewModels
{
    public partial class ToDoItemViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _isChecked;

        [ObservableProperty]
        private string? _content;


        public ToDoItemViewModel() { }

        public ToDoItemViewModel(ToDoItem item)
        {
            IsChecked = item.IsChecked;
            Content = item.Content;
        }
    }
}
