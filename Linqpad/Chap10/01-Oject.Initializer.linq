<Query Kind="Program" />

void Main()
{
	// Object initializer
	MyRectangle r = new MyRectangle() { x = 10, y = 5 };
	// If there are no arguments for the constructor, 
	// the parentheses may be removed
	MyRectangle s = new MyRectangle { x = 10, y = 5 };
}

// Define other methods, classes and namespaces here
// Object initializers
class MyRectangle
{
	public int x, y;
}