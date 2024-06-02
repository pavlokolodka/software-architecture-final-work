package builderPattern;

class ConcreteBuilder implements Builder {
    private Product product = new Product();

    @Override
    public void buildPartA() {
        product.setPartA("PartA built");
    }

    @Override
    public void buildPartB() {
        product.setPartB("PartB built");
    }

    @Override
    public Product getResult() {
        return product;
    }
}

