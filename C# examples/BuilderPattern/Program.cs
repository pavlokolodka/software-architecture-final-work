using BuilderPattern;

Director director = new Director();
IBuilder builder = new ConcreteBuilder();

director.Construct(builder);
Product product = builder.GetResult();
product.Show();