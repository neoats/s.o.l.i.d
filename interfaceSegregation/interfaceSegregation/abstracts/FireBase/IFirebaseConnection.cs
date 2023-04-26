namespace interfaceSegregation.abstracts.FireBase;

public interface IFirebaseConnection
{
    void Connect(string connectionString);
    void Disconnect();
}