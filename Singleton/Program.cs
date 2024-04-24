Console.WriteLine("This is a thread safe Singleton.");
Console.WriteLine("\n\n\nRESULT:\n\n\n");

Thread process1 = new Thread(() =>
{
    Singleton singleton = Singleton.GetInstance("Singleton Instance 1️⃣");
    Console.WriteLine(singleton.Value);
});

Thread process2 = new Thread(() =>
{
    Singleton singleton = Singleton.GetInstance("Singleton Instance 2️⃣");
    Console.WriteLine(singleton.Value);
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();

