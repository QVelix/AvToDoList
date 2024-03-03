using System;
using System.Reactive.Linq;
using AvToDoList.DataModel;
using AvToDoList.Services;
using ReactiveUI;

namespace AvToDoList.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
	public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
	private ToDoListViewModel _toDoList;
	private ViewModelBase _contentViewModel;

	public MainWindowViewModel()
	{
		var service = new ToDoListService();
		_toDoList = new ToDoListViewModel(service.GetItems());
		_contentViewModel = ToDoList;
	}

	public ToDoListViewModel ToDoList
	{
		get { return _toDoList; }
	}

	public ViewModelBase ContentViewModel
	{
		get { return _contentViewModel; }
		private set { this.RaiseAndSetIfChanged(ref _contentViewModel, value); }
	}

	public void AddItem()
	{
		AddItemViewModel addItemViewModel = new();

		Observable.Merge(addItemViewModel.OkCommand, addItemViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
			.Take(1)
			.Subscribe(newItem =>
			{
				if (newItem != null)
				{
					ToDoList.ListItems.Add(newItem);
				}

				ContentViewModel = ToDoList;
			});
		ContentViewModel = addItemViewModel;
	}
}