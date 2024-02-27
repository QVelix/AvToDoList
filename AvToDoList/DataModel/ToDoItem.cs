using System;

namespace AvToDoList.DataModel;

public class ToDoItem
{
	string _description = String.Empty;
	bool _isChecked;
	
	public string Description
	{
		get { return _description; }
		set { _description = value; }
	}

	public bool IsChecked
	{
		get { return _isChecked; }
		set { _isChecked = value; }
	}
}