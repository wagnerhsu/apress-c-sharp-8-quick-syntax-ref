<Query Kind="Program" />

void Main()
{
	MyClass c = new MyClass();
	c.name = null; // exception: name was null
}

// Define other methods, classes and namespaces here
class MyClass
{
	private string _name;
	public string name
	{
		get => _name;
		set => _name = value ?? throw new
		  ArgumentNullException(nameof(name) + " was null");
	}

}