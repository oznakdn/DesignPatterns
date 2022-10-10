using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using enumerationSingleton;

for (var i = 0; i < 10; i++)
{
    EnumSingleton.enumSingleton single = EnumSingleton.enumSingleton.SINGLETON;
    Console.WriteLine(single.ToString());
}


