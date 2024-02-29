using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvToDoList.DataModel;

namespace AvToDoList.ViewModels;

public class ToDoListViewModel : ViewModelBase
{
	ObservableCollection<ToDoItem> _listItems;

	public ToDoListViewModel(IEnumerable<ToDoItem> items)
	{
		_listItems = new ObservableCollection<ToDoItem>(items);
	}

	public ObservableCollection<ToDoItem> ListItems
	{
		get { return _listItems; }
	}
}