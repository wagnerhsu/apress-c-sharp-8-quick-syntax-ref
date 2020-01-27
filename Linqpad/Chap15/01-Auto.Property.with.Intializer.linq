<Query Kind="Program" />

void Main()
{
	Time t = new Time();
	t.Created.Dump();
	Thread.Sleep(6000);
	t.Created.Dump();
	
}

// Define other methods, classes and namespaces here
// Auto-implemented properties
class Time
{
	// Auto-implemented property
	public int sec { get; set; }

	// Read-only auto-property with initializer
	// 注意：只是初始值，因此多次调用会返回相同的值
	public System.DateTime Created { get; } = System.DateTime.Now;
}