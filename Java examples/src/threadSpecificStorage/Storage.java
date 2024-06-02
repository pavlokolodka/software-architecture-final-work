package threadSpecificStorage;

public class Storage {
    private static ThreadLocal<Data> threadLocalData = ThreadLocal.withInitial(Data::new);
    // not a thread-specific data
    // private static Data threadLocalData =  new Data();

    public static Data getData() {
        return threadLocalData.get();
    }
}
