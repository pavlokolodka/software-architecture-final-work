namespace BuilderPattern
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }
}