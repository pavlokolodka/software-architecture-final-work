using System;

namespace NullObjectPattern
{
    public interface IObject
    {
        void Operation();
    }

    public class RealObject : IObject
    {
        public void Operation()
        {
            Console.WriteLine("RealObject Operation");
        }
    }

    public class NullObject : IObject
    {
        public void Operation()
        {
        }
    }

    class Program
    {
        public static void RunExample()
        {
            Random rnd = new Random();
            int randomValue = rnd.Next();
            IObject returnObject = randomValue % 2 == 0 ? new RealObject() : new NullObject();

            returnObject.Operation(); 
        }
    }
}
