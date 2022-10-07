using volatileSingleton;


Client client = new Client();

for (var i = 0; i < 100; i++)
{
    Thread thread = new Thread(client.Run);
    thread.Start();
}

public class Client
{
    public void Run()
    {
        VolatileSingleton vs = VolatileSingleton.Instance;
        vs.GetName();
    }
}