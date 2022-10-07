namespace threadedLazySingleton
{
    public class ThreadedLazySingleton
    {
        private static ThreadedLazySingleton threadedLazySingleton;

        private static int count=0;
        private readonly string name;

        private ThreadedLazySingleton()
        {
            count++;
            name = $"ThreadedLazySingleton {count}";
        }

        public static ThreadedLazySingleton Instance 
        {
            get => threadedLazySingleton is null ? threadedLazySingleton = new ThreadedLazySingleton()
                                                 : threadedLazySingleton;
        }

        public void WriteName()
        {
            Console.WriteLine(name);
        }




    }
}