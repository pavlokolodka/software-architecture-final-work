namespace BuilderPattern
{
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
}