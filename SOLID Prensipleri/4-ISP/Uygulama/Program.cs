
IDataChannel data = new Modem();
data.Recv();
data.Send('f');

IConnection connection = new Modem();
connection.Dial("");
connection.HangUp();


public interface IDataChannel
{
    void Send(char a);
    Char Recv();
}

public interface  IConnection
{
    void Dial(string connectionName);
    void HangUp();
}


public class Modem : IDataChannel, IConnection
{

    public Modem()
    {
        
    }
    public void Dial(string connectionName)
    {
        throw new NotImplementedException();
    }

    public void HangUp()
    {
        throw new NotImplementedException();
    }

    public char Recv()
    {
        throw new NotImplementedException();
    }

    public void Send(char a)
    {
        throw new NotImplementedException();
    }
}
