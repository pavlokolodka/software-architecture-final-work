using ThreadSpecificStoragePattern;

Thread thread1 = new Thread(() =>
{
    Data data = Storage.GetData();
    Console.WriteLine($"Thread 1 data before {data.Value}");
    data.Value = "Data for Thread 1";
    Console.WriteLine($"Thread 1 data after {data.Value}");
});

Thread thread2 = new Thread(() =>
{
    Data data = Storage.GetData();
    Console.WriteLine($"Thread 2 data before {data.Value}");
    data.Value = "Data for Thread 2";
    Console.WriteLine($"Thread 2 data after {data.Value}");
});

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();