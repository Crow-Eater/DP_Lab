public class MySQLDatabase
{
    public void Save(string data) {}
}

public class DataService
{
    private MySQLDatabase db = new MySQLDatabase();

    public void Store(string data)
    {
        db.Save(data);
    }
}
