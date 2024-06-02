using System;

namespace BuilderPattern
{
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }

        public void Show()
        {
            Console.WriteLine($"PartA: {PartA}, PartB: {PartB}");
        }
    }

    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.PartA = "PartA built";
        }

        public void BuildPartB()
        {
            _product.PartB = "PartB built";
        }

        public Product GetResult()
        {
            return _product;
        }
    }

    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    static class Program
    {
        public static void RunExample()
        {
            Director director = new Director();
            IBuilder builder = new ConcreteBuilder();

            director.Construct(builder);
            Product product = builder.GetResult();
            product.Show();
        }
    }
}
