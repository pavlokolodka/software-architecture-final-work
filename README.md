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

## ������ ������������ Front Controller

���������: https://www.baeldung.com/java-front-controller-pattern
### ����������� �� ������������ �������
������ ������������ Front Controller ��������������� ��� ��������������� ��������� �������� ������ � ���-�����������. ³� �������� �� ������ ������������ ��������� ����� ���� ��'��� ����������, ���� ���� ��������� �� �������� ������. �� �������� ��������� � ���������� ������� ������, ����������� �������� ��� �������� � ���������� ������� �����, ����� �� ��������������, ��������� ��� ��������� ����.

### ������ ������� ������������:

- ���� ��������� ������������� �������� �������� ������.
- ���� ������� ���������� ������� ������ (��������������, ��������� ����) ��� ������� ������.
- ���� ������ �������� ���������� ���� � �����������.


### ���� �������� ����������� ��������
- FrontController: ����������� ��'���, ���� ������ �� ������, ������� ������� 䳿 ��� �� ������� �� �������� ������ � ������ ������������.
- Dispatcher: ³������ �� ��������������� ������ �� ���������� ���������� �� ���������.
- Controller: ���������� ��� ��������� ��� ����� ���������� ����������, �� ���������� ��� ���� ������.
- View: ���������, ���� ������� �� ������������� ����� �����������.


### UML �������

ĳ������ �����:

```mermaid
classDiagram
    class FrontController {
        -dispatcher: Dispatcher
        +handleRequest(request: Request): void
    }
    
    class Dispatcher {
        +dispatch(request: Request): void
    }
    
    class Controller {
        <<interface>>
        +processRequest(request: Request): void
    }
    
    class ConcreteController1 {
        +processRequest(request: Request): void
    }
    
    class ConcreteController2 {
        +processRequest(request: Request): void
    }
    
    class View {
        +show(): void
    }
    
    FrontController --> Dispatcher
    Dispatcher --> Controller
    Controller <|-- ConcreteController1
    Controller <|-- ConcreteController2
    ConcreteController1 --> View
    ConcreteController2 --> View

```

ĳ������ �����:

```mermaid
stateDiagram
    [*] --> Waiting
    Waiting --> HandlingRequest: handleRequest()
    HandlingRequest --> Dispatching: dispatch(request)
    Dispatching --> Processing: processRequest()
    Processing --> Rendering: render()
    Rendering --> Waiting: show()
    Rendering --> [*]

```

## ������ ������������ Null Object

���������: https://refactoring.guru/introduce-null-object

### ����������� �� ������������ �������
������ ������������ Null Object ��������������� ��� ������������ �������� "����������" ��'����, ���� ����� ��������������� �� ������� null-���������. ³� �������� �������� �������� �� null, ��������� ��� �� ��������� ���� ��������.

### ������ ������� ������������:

- ���� ������� �������� ��������� �������� �� null.
- ���� ������� ������ �������� �������� � ��������, ���� ��'��� �� �������.
- ���� ������������ null ���� ��������� ������� ��� ���������� ����� ��������.


### ���� �������� ����������� ��������
- AbstractObject (����������� ��'���): ��������� ��� ����������� ����, �� ������� ������� ������ ��� ��� ���������� �� �������� ��'����.
- RealObject (�������� ��'���): ����, �� ������ AbstractObject � ����������� ����� ������� ���������������.
- NullObject (�������� ��'���): ����, �� ������ AbstractObject � ���� ��������, "�������" ��������.

### UML �������
ĳ������ �����:
```mermaid
classDiagram
    class AbstractObject {
        <<interface>>
        +operation(): void
    }
    
    class RealObject {
        +operation(): void
    }
    
    class NullObject {
        +operation(): void
    }
    
    AbstractObject <|-- RealObject
    AbstractObject <|-- NullObject

```
ĳ������ �����:
```mermaid
stateDiagram
    [*] --> CheckObject
    CheckObject --> RealOperation: isRealObject
    CheckObject --> NullOperation: isNullObject
    RealOperation --> [*]
    NullOperation --> [*]

```