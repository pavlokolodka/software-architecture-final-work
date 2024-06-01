## ������ ������������ Builder

���������: [https://refactoring.guru/uk/design-patterns/builder](https://refactoring.guru/uk/design-patterns/builder)
### ����������� �� ������������ �������

������ ������������ Builder (����������) ��������������� ��� ��������� ������� �������� ��������� ��'���� �� ����� �������, �� �������� ��������� ���������� ��� ��'���. ��� ������ �������� ��������, ���� ��������� �������� ��� ������������� ��'���� ��� ���� ������ �������� ��'���� ������ � ���� ������ �����.

### ������ ������� ������������:

- ���� ������ ��������� ��'���� ���������� � �������� ����� ��� �������� �������.
- ���� ������ ��� ������� ������������� ��'����.
- ���� ������� ����������� �������� ��� �������� ��������� ��������� ��'����.


### ���� �������� ����������� ��������
- Builder (����������): ���������, ���� ������� ������ ��� �������� ����� ������ ��'����.
- ConcreteBuilder (���������� ����������): ����, ���� ������ ��������� Builder � ��������� ��������� ��������� ������ ��������. ϳ������ ����� ��� ��������� ����������.
- Director (��������): ����, ���� ���� ��������� ��'����, �������������� ��'��� Builder. �� � ������ �����������, ����� ��������� ������ ����������� ������������� � �볺�������� ����.
- Product (�������): ����, ���� ����������� �������� ��'���, �� ��������. ̳����� �������, �� ���� ������� ConcreteBuilder.

### ���������

```
Director director = new Director();
ConcreteBuilder concreteBuilder = new ConcreteBuilder();
director.make(concreteBuilder);
Product product = concreteBuilder.getResult();
```

### UML �������

ĳ������ �����:

```mermaid

classDiagram
    class Director {
        -builder: Builder
        +make(Builder): void
    }
    
    class Builder {
        <<interface>>
        +buildPartA(): void
        +buildPartB(): void
        +getResult(): Product
    }
    
    class ConcreteBuilder {
        -product: Product
        +buildPartA(): void
        +buildPartB(): void
        +getResult(): Product
    }
    
    class Product {
        -partA: PartA
        -partB: PartB
        +show(): void
    }
    
    Director --> Builder
    Builder <|-- ConcreteBuilder
    ConcreteBuilder --> Product
    Product --> PartA
    Product --> PartB 
```

ĳ������ �����:

```mermaid
stateDiagram
    [*] --> Initializing
    Initializing --> BuildingPartA: buildPartA()
    BuildingPartA --> BuildingPartB: buildPartB()
    BuildingPartB --> Finalizing: getResult()
    Finalizing --> [*]
```