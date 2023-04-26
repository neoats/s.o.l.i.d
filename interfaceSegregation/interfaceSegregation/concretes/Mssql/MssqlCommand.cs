using interfaceSegregation.abstracts.Mssql;
using Microsoft.Data.SqlClient;

namespace interfaceSegregation.concretes.Mssql;

public class MssqlCommand : IMssqlCommand
{
    private readonly SqlConnection _connection;

    public MssqlCommand(SqlConnection connection)
    {
        _connection = connection;
    }

    /// <inheritdoc />

    public void Connect(string connectionString)
    {
        return;
    }

    public void Disconnect()
    {
        return;
    }

    public void ExecuteNonQuery(string commandText, IDictionary<string, object> parameters)
    {
        return;
    }

    public void BeginTransaction()
    {
        return;
    }

    public void CommitTransaction()
    {
        return;
    }

    public void RollbackTransaction()
    {
        return;
    }
}