using NullObjectPattern;

Random rnd = new Random();
int randomValue = rnd.Next();
IObject returnObject = randomValue % 2 == 0 ? new RealObject() : new NullObject();

returnObject.Operation();