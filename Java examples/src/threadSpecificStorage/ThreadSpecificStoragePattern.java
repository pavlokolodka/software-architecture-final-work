package threadSpecificStorage;

public class ThreadSpecificStoragePattern {
    public static void main(String[] args) {
        Thread thread1 = new Thread(() -> {
            Data data = Storage.getData();
            System.out.println("Thread 1 data before: " + data.getValue());
            data.setValue("Data for Thread 1");
            System.out.println("Thread 1 data after: " + data.getValue());
        });

        Thread thread2 = new Thread(() -> {
            Data data = Storage.getData();
            System.out.println("Thread 2 data before: " + data.getValue());
            data.setValue("Data for Thread 2");
            System.out.println("Thread 2 data after: " + data.getValue());
        });

        thread1.start();
        thread2.start();

        try {
            thread1.join();
            thread2.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
