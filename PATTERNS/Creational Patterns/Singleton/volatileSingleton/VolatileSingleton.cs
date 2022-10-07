using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace volatileSingleton
{
    public class VolatileSingleton
    {
        private static volatile VolatileSingleton volatileSingleton;
        private static Object lockObject = new Object();

        private int count = 0;
        private readonly string name;

        private VolatileSingleton()
        {
            count++;
            name = $"VolatileSingleton {count}";
        }

        public static VolatileSingleton Instance
        {
            get
            {
                if (volatileSingleton is null)
                {
                    lock (lockObject)
                    {
                        if (volatileSingleton is null)
                            volatileSingleton = new VolatileSingleton();
                    }
                }

                return volatileSingleton;

            }
        }

        public void GetName()
        {
            Console.WriteLine(name);
        }


    }
}