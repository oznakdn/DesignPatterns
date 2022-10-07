using lazySingleton;

LazySingleton s = LazySingleton.Instance;
for (var i = 0; i < 5; i++)
{
    s.PrintName();
}

/* Result:
LazySingleton 1
LazySingleton 1
LazySingleton 1
LazySingleton 1
LazySingleton 1
*/
