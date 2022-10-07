using threadedLazySingleton;


Client client = new Client();
for (var i = 0; i < 200; i++)
{
    Thread thr = new Thread(new ThreadStart(client.Run));
    thr.Start();
}

public class Client
{
    public void Run()
    {
        ThreadedLazySingleton tls = ThreadedLazySingleton.Instance;
        tls.WriteName();
    }
}

/* Result:

ThreadedLazySingleton 11
ThreadedLazySingleton 11
ThreadedLazySingleton 11
ThreadedLazySingleton 11
ThreadedLazySingleton 11
ThreadedLazySingleton 8
ThreadedLazySingleton 9
ThreadedLazySingleton 12
ThreadedLazySingleton 11
ThreadedLazySingleton 11
ThreadedLazySingleton 10
ThreadedLazySingleton 11
ThreadedLazySingleton 8
ThreadedLazySingleton 8

*/
