<Query Kind="Program" />

void Main()
{
	
}

// Define other methods, classes and namespaces here
// Destructor
class MyComponent
{
	public System.ComponentModel.Component comp;

	public MyComponent()
	{
		comp = new System.ComponentModel.Component();
	}

	// Destructor
	~MyComponent()
	{
		comp.Dispose();
	}
}