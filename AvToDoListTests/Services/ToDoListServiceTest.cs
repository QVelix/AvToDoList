using System.Collections;
using AvToDoList.DataModel;
using AvToDoList.Services;
using JetBrains.Annotations;

namespace AvToDoListTests.Services;

[TestSubject(typeof(ToDoListService))]
public class ToDoListServiceTest
{
	[Fact]
	public void GetItems_returns_ToDoItemEnumerable()
	{
		ToDoListService test = new ToDoListService();
		var result = test.GetItems();
		Assert.IsAssignableFrom<IEnumerable<ToDoItem>>(result);
	}

	[Fact]
	public void GetItems_returns_three_items()
	{
		ToDoListService test = new ToDoListService();
		var result = test.GetItems();
		Assert.Equal(3, result.Count());
	}
}