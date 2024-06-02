namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder pattern: ");

            BuilderPattern.Program.RunExample();

            Console.WriteLine("Front Controller pattern: ");

            FrontControllerPattern.Program.RunExample();

            Console.WriteLine("Null Object pattern: ");

            NullObjectPattern.Program.RunExample();

            Console.WriteLine("Thread-Specific Storage pattern: ");

            ThreadSpecificStoragePattern.Program.RunExample();
        }
    }
}

