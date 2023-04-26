using liskovSubstitution.reader.abstracts;
using liskovSubstitution.reader;
using liskovSubstitution.reader.concretes;

namespace liskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            myPaths paths = new myPaths();
            
            IReader jsonReader = new JsonReader();
            IReader xmlReader = new XmlReader();
            IReader txtReader = new TxtReader();

            client.ReadFiles(jsonReader, paths.testxml);
            
        }
       
    }
}