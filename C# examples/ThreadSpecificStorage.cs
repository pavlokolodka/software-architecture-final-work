using System;
using System.Threading;

namespace ThreadSpecificStoragePattern
{
    public class Data
    {
        public string Value { get; set; } = "Default Value";
    }

    public static class Storage
    {
        private static ThreadLocal<Data> _threadLocalData = new ThreadLocal<Data>(() => new Data());
        
        // not a thread-specific data
        // private static Data _threadLocalData = new Data();

        public static Data GetData()
        {
            return _threadLocalData.Value;
        }
    }

    class Program
    {
        public static void RunExample()
        {
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
        }
    }
}
