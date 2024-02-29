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
		ContentViewModel = new AddItemViewModel();
	}
}