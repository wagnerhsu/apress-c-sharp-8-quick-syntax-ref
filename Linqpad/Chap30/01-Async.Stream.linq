<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	await MyApp.Main();
}

// Define other methods, classes and namespaces here
class MyApp
{
	static async IAsyncEnumerable<int> MyStream(int count)
	{
		int sum = 0;
		for (int i = 0; i <= count; i++)
		{
			sum = sum + i;
			yield return sum; // return a result
							  // Simulate waiting for more data 
			await Task.Delay(1000);
		}
		// end stream
	}

	public static async Task Main()
	{
		await foreach (int data in MyStream(3))
		{
			System.Console.Write(data + " "); // "0 1 3 6"
		}
	}
}