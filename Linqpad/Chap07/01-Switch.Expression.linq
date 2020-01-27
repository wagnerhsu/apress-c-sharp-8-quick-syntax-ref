<Query Kind="Program" />

void Main()
{
	int x = new System.Random().Next(4);
	string result = x switch
	{
		0 => "zero",
		1 => "one",
		_ => "more than one"
	};
	System.Console.WriteLine("x is " + result);
}

// Define other methods, classes and namespaces here
