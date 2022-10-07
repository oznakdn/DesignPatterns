using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace singleton
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        private static int count = 0;
        private readonly string name;

        private Singleton()
        {
            count++;
            name = $"Singleton {count}";
        }

        public static Singleton Instance {get => singleton;}

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}