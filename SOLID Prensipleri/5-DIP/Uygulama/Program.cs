

public interface IReader
{
    void Read();
    void Close();
}


public class Keyboard : IReader
{
    public Keyboard()
    {
        
    }
    public void Close()
    {
        throw new NotImplementedException();
    }

    public void Read()
    {
        throw new NotImplementedException();
    }
}

public class FileReader : IReader
{

    public FileReader()
    {
        
    }
    public void Close()
    {
        throw new NotImplementedException();
    }

    public void Read()
    {
        throw new NotImplementedException();
    }
}


/*****************************************************/
public interface IWriter
{
    void Write();
    void Close();
}

public class FileWriter : IWriter
{
    public FileWriter()
    {
        
    }
    public void Close()
    {
        throw new NotImplementedException();
    }

    public void Write()
    {
        throw new NotImplementedException();
    }
}

public class Printer : IWriter
{
    public Printer()
    {
        
    }
    public void Close()
    {
        throw new NotImplementedException();
    }

    public void Write()
    {
        throw new NotImplementedException();
    }
}