using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceSegregation.abstracts
{
    public interface IMssqlConnection
    {
        void Connect(string connectionString);
        void Disconnect();
    }
}
