using singleton;

Singleton s = Singleton.Instance;

for (var i = 0; i < 5; i++)
{
    s.PrintName();
}

/* Result:

Singleton 1
Singleton 1
Singleton 1
Singleton 1
Singleton 1

*/
