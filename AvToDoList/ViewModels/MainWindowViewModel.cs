using AvToDoList.Services;

namespace AvToDoList.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
	public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
	private ToDoListViewModel _toDoList;

	public MainWindowViewModel()
	{
		var service = new ToDoListService();
		_toDoList = new ToDoListViewModel(service.GetItems());
	}

	public ToDoListViewModel ToDoList
	{
		get { return _toDoList; }
	}
}