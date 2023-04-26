using Microsoft.Data.SqlClient;

namespace interfaceSegregation.abstracts.Mssql;

public interface IMssqlCommand
{
    void ExecuteNonQuery(string commandText, IDictionary<string, object> parameters);
    void BeginTransaction();
    void CommitTransaction();
    void RollbackTransaction();
}