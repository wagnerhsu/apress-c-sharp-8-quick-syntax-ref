<Query Kind="Program" />

void Main()
{
	int[] b = { 1, 2, 3, 4, 5 };
	foreach (int n in b[1..3])
	{
		System.Console.Write(n); // "23"
	}

	System.Range range = 0..3; // 1st to 3rd
	foreach (int n in b[range])
	{
		System.Console.Write(n); // "123"
	}

	string s = "welcome";
	System.Index first = 0;
	System.Index last = ^1;
	System.Console.Write($"{s[first]}, {s[last]}"); // "w, e"
}

// Define other methods, classes and namespaces here
