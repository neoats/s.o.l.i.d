using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskovSubstitution.reader.abstracts
{
    interface IReader
    {
        string Read(string filePath);
      
    }
}
