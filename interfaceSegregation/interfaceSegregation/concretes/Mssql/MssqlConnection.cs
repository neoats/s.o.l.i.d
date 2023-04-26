using interfaceSegregation.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceSegregation.concretes.Mssql
{
    public class MssqlConnection : IMssqlConnection
    {
        public void Connect(string connectionString)
        {
            // MSSQL bağlantısı açma işlemleri
        }

        public void Disconnect()
        {
            // MSSQL bağlantısı kapama işlemleri
        }
    }
}
