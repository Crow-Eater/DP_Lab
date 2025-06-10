public interface IMultiFunctionDevice
{
    void Print();
    void Scan();
    void Fax();
}

public class OldPrinter : IMultiFunctionDevice
{
    public void Print() { }
    public void Scan() { }
    public void Fax()
    {
        throw new NotSupportedException();
    }
}
