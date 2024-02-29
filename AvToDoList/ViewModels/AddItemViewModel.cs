using System;

namespace AvToDoList.ViewModels;

public class AddItemViewModel : ViewModelBase
{
	private string _description = String.Empty;

	public string Description
	{
		get { return _description; }
		set { _description = value; }
	}
}