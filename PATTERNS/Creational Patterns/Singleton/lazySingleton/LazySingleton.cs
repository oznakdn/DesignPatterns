using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lazySingleton
{
    public class LazySingleton
    {
        private static LazySingleton singleton;

        private static int count = 0;
        private readonly string name;

        private LazySingleton()
        {
            count ++;
            name = $"LazySingleton {count}";
        }

        public static LazySingleton Instance
        {
            get
            {
               return singleton is null ? singleton = new LazySingleton()
                                  : singleton;
            }
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}