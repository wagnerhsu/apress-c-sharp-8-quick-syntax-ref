<Query Kind="Program" />

void Main()
{
	try
	{
		StreamReader sr = new StreamReader("missing.txt");
	}
	catch (FileNotFoundException e)
	when (e.FileName.Contains(".txt"))
	{
		Console.WriteLine("Missing text file: " + e.FileName);
	}
}

// Define other methods, classes and namespaces here
