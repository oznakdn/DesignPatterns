using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doubleCheckLockingSingleton
{
    public class DoubleCheckLockingSingleton
    {
        private static DoubleCheckLockingSingleton doubleCheckLockingSingleton;
        private static Object lockObject = new Object();

        private int count = 0;
        private readonly string name;

        private DoubleCheckLockingSingleton()
        {
            count++;
            name = $"DoubleCheckLockingSingleton {count}";
        }

        public static DoubleCheckLockingSingleton Instance
        {
            get
            {
                if (doubleCheckLockingSingleton is null)
                {
                    lock (lockObject)
                    {
                        if (doubleCheckLockingSingleton is null)
                            doubleCheckLockingSingleton = new DoubleCheckLockingSingleton();
                    }


                }

                return doubleCheckLockingSingleton;
            }
        }

        public void GetName()
        {
            Console.WriteLine(name);
        }

    }
}