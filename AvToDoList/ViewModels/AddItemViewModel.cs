using System;
using System.Reactive;
using AvToDoList.DataModel;
using ReactiveUI;

namespace AvToDoList.ViewModels;

public class AddItemViewModel : ViewModelBase
{
	private string _description = String.Empty;
	
	public string Description
	{
		get { return _description; }
		set { this.RaiseAndSetIfChanged(ref _description, value); }
	}
	public ReactiveCommand<Unit, ToDoItem> OkCommand { get; }
	public ReactiveCommand<Unit, Unit> CancelCommand { get; }
	
}