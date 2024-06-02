package nullObject;

import java.util.Random;

public class NullObjectPattern {
    public static void main(String[] args) {
        System.out.println("Null Object pattern");
        Random rn = new Random();
        int randomValue = rn.nextInt();
        IObject returnObject = randomValue % 2 == 0 ? new RealObject() : new NullObject();

        returnObject.operation();

    }
}
