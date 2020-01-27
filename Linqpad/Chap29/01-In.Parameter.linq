<Query Kind="Program" />

void Main()
{
	MyApp.Main();
}

// Define other methods, classes and namespaces here
// In parameters
class MyApp
{
	static void Test(in int num)
	{
		// num = 5; // error: readonly parameter
	}

	public static void Main()
	{
		int i = 10;
		Test(i); // passed by readonly reference
		Test(2); // allowed, temporary variable created
	}
}