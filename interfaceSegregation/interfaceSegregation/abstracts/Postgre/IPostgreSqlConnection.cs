namespace interfaceSegregation.abstracts;

public interface IPostgreSqlConnection
{
    void Connect(string connectionString);
    void Disconnect();
}