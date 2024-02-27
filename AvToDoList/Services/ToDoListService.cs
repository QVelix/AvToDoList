using System.Collections.Generic;
using AvToDoList.DataModel;

namespace AvToDoList.Services;

public class ToDoListService
{
	public IEnumerable<ToDoItem> GetItems() => new[]
	{
		new ToDoItem() { Description = "Walk the milk" },
		new ToDoItem() { Description = "Buy some cat" },
		new ToDoItem() { Description = "Learn Avalonia", IsChecked = true }
	};
}