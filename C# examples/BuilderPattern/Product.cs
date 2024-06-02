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
}