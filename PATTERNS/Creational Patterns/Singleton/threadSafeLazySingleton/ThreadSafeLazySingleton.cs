using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace threadSafeLazySingleton
{
    public class ThreadSafeLazySingleton
    {
        private static ThreadSafeLazySingleton threadSafeLazySingleton;
        private static readonly Object lockObject = new Object();
        private int count=0;
        private readonly string name;

        private ThreadSafeLazySingleton()
        {
            count ++;
            name = $"ThreadSafeLazySingleton {count}";
        }

        public static ThreadSafeLazySingleton Instance
        {
            get
            {
                lock(lockObject)
                return threadSafeLazySingleton is null ? threadSafeLazySingleton = new ThreadSafeLazySingleton()
                                                       : threadSafeLazySingleton;
            }
        }

        public void GetName()
        {
            Console.WriteLine(name);
        }
    }
}