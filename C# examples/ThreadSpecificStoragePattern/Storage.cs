namespace ThreadSpecificStoragePattern
{
    public static class Storage
    {
        private static ThreadLocal<Data> _threadLocalData = new ThreadLocal<Data>(() => new Data());

        // not a thread-specific data
        // private static Data _threadLocalData = new Data();

        public static Data GetData()
        {
            return _threadLocalData.Value;
        }
    }
}
