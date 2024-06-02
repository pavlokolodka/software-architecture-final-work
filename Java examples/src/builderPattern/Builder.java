package builderPattern;

public interface Builder {
    void buildPartA();
    void buildPartB();
    Product getResult();
}