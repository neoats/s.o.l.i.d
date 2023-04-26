using Npgsql;

namespace interfaceSegregation.abstracts.Postgre;

public interface IPostgreSqlCommand
{
    void CreateDatabase(string databaseName);
    void DropDatabase(string databaseName);
    void CreateTable(string tableName, string[] columnNames, string[] dataTypes);
    void DropTable(string tableName);
    void RenameTable(string oldTableName, string newTableName);
    void Insert(string tableName, string[] columnNames, object[] values);
    void Update(string tableName, string[] columnNames, object[] values, string condition);
    void Delete(string tableName, string condition);
    void Select(string tableName, string[] columnNames, string condition);
}
