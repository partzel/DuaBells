using DuaBells.Models;
using DuaBells.ViewModels;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using CommunityToolkit.Mvvm.Input;

namespace DuaBells.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
        private string? _newItemContent;


        private bool CanAddItem() => (!string.IsNullOrEmpty(NewItemContent));

        [RelayCommand(CanExecute = nameof(CanAddItem))]
        private void AddItem()
        {
            var newItem = new ToDoItemViewModel
            {
                Content = NewItemContent
            };

            ToDoItems.Add(newItem);
            NewItemContent = null;
        }

        [RelayCommand]
        private void RemoveItem(ToDoItemViewModel item) => ToDoItems.Remove(item);
    }
}
